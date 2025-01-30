using System;
using System.Drawing;
using System.Windows.Forms;
using Interop.UIAutomationClient;

namespace NoNeedToLearnCantonese
{
    public class CaretDetector
    {
        // 将鼠标移动到文本框光标位置
        // 备用

        public static Point? GetCaretPosition()
        {
            try
            {
                CUIAutomation automation = new CUIAutomation();
                IUIAutomationElement focusedElement = automation.GetFocusedElement();

                // 检查焦点元素是否存在
                if (focusedElement == null)
                {
                    MessageBox.Show("无法获取焦点元素！");
                    return null;
                }

                // 获取 TextPattern
                object patternObj = focusedElement.GetCurrentPattern(UIA_PatternIds.UIA_TextPatternId);
                if (patternObj == null)
                {
                    MessageBox.Show("当前焦点元素不支持输入光标！");
                    return null;
                }

                // 转换为 TextPattern 接口
                IUIAutomationTextPattern textPattern = (IUIAutomationTextPattern)patternObj;

                // 获取选中范围
                IUIAutomationTextRangeArray selectionRanges = textPattern.GetSelection();
                if (selectionRanges.Length == 0)
                {
                    MessageBox.Show("未检测到输入光标！");
                    return null;
                }

                // 提取第一个光标范围
                IUIAutomationTextRange caretRange = selectionRanges.GetElement(0);

                // 获取光标坐标（屏幕坐标）
                double[] rects = caretRange.GetBoundingRectangles();
                if (rects != null && rects.Length >= 4)
                {
                    // 返回坐标（转换为整数像素值）
                    return new Point((int)rects[0], (int)rects[1]);
                }
                else
                {
                    MessageBox.Show("无法获取光标坐标！");
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"错误：{ex.Message}");
                return null;
            }
        }
    }
}