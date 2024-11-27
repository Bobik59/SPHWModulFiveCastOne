namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            listReport = new ListBox();
            chkSentences = new CheckBox();
            chkWords = new CheckBox();
            chkCharacters = new CheckBox();
            chkQuestionSentences = new CheckBox();
            chkExclamatorySentences = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 12);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(272, 426);
            txtInput.TabIndex = 0;
            // 
            // listReport
            // 
            listReport.FormattingEnabled = true;
            listReport.ItemHeight = 15;
            listReport.Location = new Point(577, 12);
            listReport.Name = "listReport";
            listReport.Size = new Size(342, 424);
            listReport.TabIndex = 1;
            // 
            // chkSentences
            // 
            chkSentences.AutoSize = true;
            chkSentences.Location = new Point(305, 14);
            chkSentences.Name = "chkSentences";
            chkSentences.Size = new Size(170, 19);
            chkSentences.TabIndex = 2;
            chkSentences.Text = "Количество предложений";
            chkSentences.UseVisualStyleBackColor = true;
            // 
            // chkWords
            // 
            chkWords.AutoSize = true;
            chkWords.Location = new Point(305, 39);
            chkWords.Name = "chkWords";
            chkWords.Size = new Size(120, 19);
            chkWords.TabIndex = 3;
            chkWords.Text = "Количество слов";
            chkWords.UseVisualStyleBackColor = true;
            // 
            // chkCharacters
            // 
            chkCharacters.AutoSize = true;
            chkCharacters.Location = new Point(305, 64);
            chkCharacters.Name = "chkCharacters";
            chkCharacters.Size = new Size(149, 19);
            chkCharacters.TabIndex = 4;
            chkCharacters.Text = "Количество символов";
            chkCharacters.UseVisualStyleBackColor = true;
            // 
            // chkQuestionSentences
            // 
            chkQuestionSentences.AutoSize = true;
            chkQuestionSentences.Location = new Point(305, 89);
            chkQuestionSentences.Name = "chkQuestionSentences";
            chkQuestionSentences.Size = new Size(266, 19);
            chkQuestionSentences.TabIndex = 5;
            chkQuestionSentences.Text = "Количество вопросительных предложений";
            chkQuestionSentences.UseVisualStyleBackColor = true;
            // 
            // chkExclamatorySentences
            // 
            chkExclamatorySentences.AutoSize = true;
            chkExclamatorySentences.Location = new Point(305, 114);
            chkExclamatorySentences.Name = "chkExclamatorySentences";
            chkExclamatorySentences.Size = new Size(271, 19);
            chkExclamatorySentences.TabIndex = 6;
            chkExclamatorySentences.Text = "Количество восклицательных предложений";
            chkExclamatorySentences.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(305, 155);
            button1.Name = "button1";
            button1.Size = new Size(266, 23);
            button1.TabIndex = 7;
            button1.Text = "Analiz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAnalyze_Click;
            // 
            // button2
            // 
            button2.Location = new Point(305, 184);
            button2.Name = "button2";
            button2.Size = new Size(266, 23);
            button2.TabIndex = 8;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnStop_Click;
            // 
            // button3
            // 
            button3.Location = new Point(305, 213);
            button3.Name = "button3";
            button3.Size = new Size(266, 23);
            button3.TabIndex = 9;
            button3.Text = "SaveFile";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnSaveReport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkExclamatorySentences);
            Controls.Add(chkQuestionSentences);
            Controls.Add(chkCharacters);
            Controls.Add(chkWords);
            Controls.Add(chkSentences);
            Controls.Add(listReport);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private ListBox listReport;
        private CheckBox chkSentences;
        private CheckBox chkWords;
        private CheckBox chkCharacters;
        private CheckBox chkQuestionSentences;
        private CheckBox chkExclamatorySentences;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
