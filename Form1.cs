using System;
using System.Windows.Forms;

namespace NoNeedToLearnCantonese
{
    public partial class MainForm : Form
    {
        private string _modelName;
        private string _apiKey;
        private string _apiUrl;
        private string _targetLanguage;
        KeyboardHook k_hook;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            targetLanguageBox.SelectedIndex = 0;
            apiTypeBox.SelectedIndex = 0;
            k_hook = new KeyboardHook();
            k_hook.KeyDownEvent += K_hook_KeyDownEvent;
            k_hook.Start();
        }

        private void K_hook_KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                MainUtils();
            }
        }

        public void MainUtils()
        {
            SendMsg sendMsg = new SendMsg();
            TextOperation textOperation = new TextOperation();

            string selectedText = TextOperation.GetTextWithoutSelection();
            TextOperation.SetTextUsingValuePattern("");

            for (int i = 0; i < 6; i++)
            {
                sendMsg.SendText("·");
                System.Threading.Thread.Sleep(20);
            }

            var AI = new AIService(_modelName, _apiKey, _apiUrl, _targetLanguage, selectedText);

            var aiResponse = AI.AskAI();

            TextOperation.SetTextUsingValuePattern("");
            sendMsg.SendText(aiResponse);

        }

        private void apiTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apiKeyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void targetLanguageBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _apiKey = apiKeyBox.Text;
            _targetLanguage = targetLanguageBox.Text;
            if (apiTypeBox.SelectedIndex == 0)
            {
                _apiUrl = "https://api.moonshot.cn/v1/chat/completions";
                _modelName = "moonshot-v1-8k";
            }
            else if (apiTypeBox.SelectedIndex == 1)
            {
                _apiUrl = "https://api.openai.com/v1/completions‌";
                _modelName = "gpt-4-turbo";
            }
            else if (apiTypeBox.SelectedIndex == 2)
            {
                _apiUrl = "https://api.deepseek.com";
                _modelName = "deepseek-chat";
            }

            this.WindowState = FormWindowState.Minimized;
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
