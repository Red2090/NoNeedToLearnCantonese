using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Interop.UIAutomationClient;

namespace NoNeedToLearnCantonese
{
    public class TextOperation
    {
        public static string GetTextWithoutSelection()
        {
            // 获取文本框里的文本
            try
            {
                CUIAutomation automation = new CUIAutomation();
                IUIAutomationElement focusedElement = automation.GetFocusedElement();

                if (focusedElement == null)
                {
                    MessageBox.Show("无法获取焦点元素！");
                    return null;
                }

                // 获取 TextPattern
                object patternObj = focusedElement.GetCurrentPattern(UIA_PatternIds.UIA_TextPatternId);
                if (patternObj == null)
                {
                    MessageBox.Show("当前焦点元素不支持文本操作！");
                    return null;
                }

                IUIAutomationTextPattern textPattern = (IUIAutomationTextPattern)patternObj;

                // 直接获取全部文本内容（无需选中）
                IUIAutomationTextRange documentRange = textPattern.DocumentRange;
                string fullText = documentRange.GetText(-1); // -1 表示获取全部文本

                return fullText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"错误：{ex.Message}");
                return null;
            }
        }

        public static void SetTextUsingValuePattern(string newText)
        {
            // 替换文本框里的文本（可以替换成空字符串）
            try
            {
                CUIAutomation automation = new CUIAutomation();
                IUIAutomationElement focusedElement = automation.GetFocusedElement();

                if (focusedElement == null)
                {
                    MessageBox.Show("无法获取焦点元素！");
                    return;
                }

                object valuePatternObj = focusedElement.GetCurrentPattern(UIA_PatternIds.UIA_ValuePatternId);

                if (valuePatternObj == null)
                {
                    MessageBox.Show("当前控件不支持 ValuePattern！");
                    return;
                }

                // 安全类型转换
                IUIAutomationValuePattern valuePattern = valuePatternObj as IUIAutomationValuePattern;
                if (valuePattern == null)
                {
                    MessageBox.Show("ValuePattern 转换失败！");
                    return;
                }

                // 设置文本（防御 null 值）
                valuePattern.SetValue(newText ?? "");

                SendKeys.SendWait("{END}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"错误：{ex.Message}");
            }
        }



        /// 备用

        [DllImport("user32.dll")]
        private static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        // 定义鼠标事件常量
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;

        public string CopyContent()
        {
            // 复制内容并读取剪贴板
            SendKeys.SendWait("^c");

            string clipboardContent = Clipboard.GetText();
            return clipboardContent;
        }

        public string GetText()
        {
            Point? caretPos = CaretDetector.GetCaretPosition();

            if (caretPos.HasValue)
            {
                // 移动鼠标到指定坐标
                Cursor.Position = caretPos.Value;

                // 执行三次点击
                for (int i = 0; i < 3; i++)
                {
                    // 发送鼠标按下事件
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    // 发送鼠标释放事件
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                    // 添加短暂延迟以确保点击生效（可选）
                    System.Threading.Thread.Sleep(5);
                }
            }
            else
            {
                MessageBox.Show("无法获取有效的光标位置！");
            }

            string text = CopyContent();
            SendKeys.SendWait("{BACKSPACE}");

            return text;
        }
    }
}

