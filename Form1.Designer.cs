namespace NoNeedToLearnCantonese
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            apiKeyBox = new System.Windows.Forms.TextBox();
            startButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            targetLanguageBox = new System.Windows.Forms.ComboBox();
            apiTypeBox = new System.Windows.Forms.ComboBox();
            leftPanel = new System.Windows.Forms.Panel();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // apiKeyBox
            // 
            apiKeyBox.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            apiKeyBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            apiKeyBox.ForeColor = System.Drawing.Color.Silver;
            apiKeyBox.Location = new System.Drawing.Point(44, 112);
            apiKeyBox.Margin = new System.Windows.Forms.Padding(4);
            apiKeyBox.Name = "apiKeyBox";
            apiKeyBox.Size = new System.Drawing.Size(380, 31);
            apiKeyBox.TabIndex = 1;
            apiKeyBox.TextChanged += apiKeyBox_TextChanged;
            // 
            // startButton
            // 
            startButton.BackColor = System.Drawing.Color.LightGray;
            startButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            startButton.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            startButton.Location = new System.Drawing.Point(89, 569);
            startButton.Margin = new System.Windows.Forms.Padding(4);
            startButton.Name = "startButton";
            startButton.Size = new System.Drawing.Size(296, 48);
            startButton.TabIndex = 3;
            startButton.Text = "开始";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            label1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            label1.ForeColor = System.Drawing.Color.Gainsboro;
            label1.Location = new System.Drawing.Point(512, 50);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 28);
            label1.TabIndex = 4;
            label1.Text = "API类型";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            label2.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            label2.ForeColor = System.Drawing.Color.Gainsboro;
            label2.Location = new System.Drawing.Point(512, 115);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 28);
            label2.TabIndex = 5;
            label2.Text = "API秘钥";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            label3.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            label3.ForeColor = System.Drawing.Color.Gainsboro;
            label3.Location = new System.Drawing.Point(512, 177);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 28);
            label3.TabIndex = 6;
            label3.Text = "目标语言";
            // 
            // targetLanguageBox
            // 
            targetLanguageBox.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            targetLanguageBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            targetLanguageBox.ForeColor = System.Drawing.Color.Silver;
            targetLanguageBox.FormattingEnabled = true;
            targetLanguageBox.Items.AddRange(new object[] { "粤语", "英语", "法语", "德语", "西语", "外星语" });
            targetLanguageBox.Location = new System.Drawing.Point(44, 173);
            targetLanguageBox.Margin = new System.Windows.Forms.Padding(4);
            targetLanguageBox.Name = "targetLanguageBox";
            targetLanguageBox.Size = new System.Drawing.Size(408, 32);
            targetLanguageBox.TabIndex = 8;
            targetLanguageBox.SelectedIndexChanged += targetLanguageBox_SelectedIndexChanged;
            // 
            // apiTypeBox
            // 
            apiTypeBox.BackColor = System.Drawing.Color.FromArgb(70, 70, 70);
            apiTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            apiTypeBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            apiTypeBox.ForeColor = System.Drawing.Color.Silver;
            apiTypeBox.FormattingEnabled = true;
            apiTypeBox.Items.AddRange(new object[] { "Moonshot", "OpenAI", "Deepseek" });
            apiTypeBox.Location = new System.Drawing.Point(44, 46);
            apiTypeBox.Margin = new System.Windows.Forms.Padding(4);
            apiTypeBox.Name = "apiTypeBox";
            apiTypeBox.Size = new System.Drawing.Size(408, 32);
            apiTypeBox.TabIndex = 9;
            apiTypeBox.SelectedIndexChanged += apiTypeBox_SelectedIndexChanged;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            leftPanel.Controls.Add(targetLanguageBox);
            leftPanel.Controls.Add(apiTypeBox);
            leftPanel.Controls.Add(startButton);
            leftPanel.Controls.Add(apiKeyBox);
            leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            leftPanel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            leftPanel.Location = new System.Drawing.Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new System.Drawing.Size(472, 663);
            leftPanel.TabIndex = 10;
            leftPanel.Paint += leftPanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(55, 55, 55);
            ClientSize = new System.Drawing.Size(1206, 663);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(leftPanel);
            ForeColor = System.Drawing.Color.DimGray;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox apiKeyBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox targetLanguageBox;
        private System.Windows.Forms.ComboBox apiTypeBox;
        private System.Windows.Forms.Panel leftPanel;
    }
}

