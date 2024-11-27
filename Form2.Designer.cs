namespace WinFormsApp7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileSystemWatcher1 = new FileSystemWatcher();
            txtSelectedFiles = new TextBox();
            txtDestinationPath = new TextBox();
            txtReport = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtSelectedFiles
            // 
            txtSelectedFiles.Location = new Point(12, 12);
            txtSelectedFiles.Multiline = true;
            txtSelectedFiles.Name = "txtSelectedFiles";
            txtSelectedFiles.Size = new Size(474, 44);
            txtSelectedFiles.TabIndex = 0;
            // 
            // txtDestinationPath
            // 
            txtDestinationPath.Location = new Point(12, 62);
            txtDestinationPath.Multiline = true;
            txtDestinationPath.Name = "txtDestinationPath";
            txtDestinationPath.Size = new Size(474, 44);
            txtDestinationPath.TabIndex = 1;
            // 
            // txtReport
            // 
            txtReport.Location = new Point(12, 125);
            txtReport.Multiline = true;
            txtReport.Name = "txtReport";
            txtReport.Size = new Size(374, 269);
            txtReport.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(492, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 45);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSelectFiles_Click;
            // 
            // button2
            // 
            button2.Location = new Point(573, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 45);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSelectDestination_Click;
            // 
            // button3
            // 
            button3.Location = new Point(492, 61);
            button3.Name = "button3";
            button3.Size = new Size(75, 45);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnProcess_Click;
            // 
            // button4
            // 
            button4.Location = new Point(573, 63);
            button4.Name = "button4";
            button4.Size = new Size(75, 45);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnGenerateReport_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtReport);
            Controls.Add(txtDestinationPath);
            Controls.Add(txtSelectedFiles);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private TextBox txtDestinationPath;
        private TextBox txtSelectedFiles;
        private TextBox txtReport;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}