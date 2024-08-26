namespace ReadFromText
{
    partial class TextFileCounter
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
            label1 = new Label();
            txtFilePath = new TextBox();
            btnLoadFile = new Button();
            rbCountLines = new RichTextBox();
            rbTime = new RichTextBox();
            btnReadAndProcessFile = new Button();
            label2 = new Label();
            label3 = new Label();
            lbResults = new ListBox();
            lbTop50 = new ListBox();
            lbTop50less6 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 8);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 0;
            label1.Text = "File to Read From and Count:";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(180, 9);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(268, 23);
            txtFilePath.TabIndex = 1;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(467, 9);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(75, 23);
            btnLoadFile.TabIndex = 2;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // rbCountLines
            // 
            rbCountLines.Enabled = false;
            rbCountLines.Location = new Point(12, 38);
            rbCountLines.Name = "rbCountLines";
            rbCountLines.ReadOnly = true;
            rbCountLines.Size = new Size(213, 152);
            rbCountLines.TabIndex = 3;
            rbCountLines.Text = "";
            // 
            // rbTime
            // 
            rbTime.Enabled = false;
            rbTime.Location = new Point(235, 38);
            rbTime.Name = "rbTime";
            rbTime.ReadOnly = true;
            rbTime.Size = new Size(213, 152);
            rbTime.TabIndex = 4;
            rbTime.Text = "";
            // 
            // btnReadAndProcessFile
            // 
            btnReadAndProcessFile.Location = new Point(454, 40);
            btnReadAndProcessFile.Name = "btnReadAndProcessFile";
            btnReadAndProcessFile.Size = new Size(148, 150);
            btnReadAndProcessFile.TabIndex = 5;
            btnReadAndProcessFile.Text = "Read and Process File";
            btnReadAndProcessFile.UseVisualStyleBackColor = true;
            btnReadAndProcessFile.Click += btnReadAndProcessFile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(683, 17);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 8;
            label2.Text = "Top 50 Words";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(842, 13);
            label3.Name = "label3";
            label3.Size = new Size(192, 15);
            label3.TabIndex = 9;
            label3.Text = "Top 50 Words with lengh < 6 letters\r\n";
            // 
            // lbResults
            // 
            lbResults.FormattingEnabled = true;
            lbResults.ItemHeight = 15;
            lbResults.Location = new Point(12, 196);
            lbResults.Name = "lbResults";
            lbResults.ScrollAlwaysVisible = true;
            lbResults.Size = new Size(590, 274);
            lbResults.TabIndex = 10;
            // 
            // lbTop50
            // 
            lbTop50.FormattingEnabled = true;
            lbTop50.ItemHeight = 15;
            lbTop50.Location = new Point(642, 44);
            lbTop50.Name = "lbTop50";
            lbTop50.Size = new Size(183, 394);
            lbTop50.TabIndex = 11;
            // 
            // lbTop50less6
            // 
            lbTop50less6.FormattingEnabled = true;
            lbTop50less6.ItemHeight = 15;
            lbTop50less6.Location = new Point(842, 44);
            lbTop50less6.Name = "lbTop50less6";
            lbTop50less6.Size = new Size(192, 394);
            lbTop50less6.TabIndex = 12;
            // 
            // TextFileCounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 490);
            Controls.Add(lbTop50less6);
            Controls.Add(lbTop50);
            Controls.Add(lbResults);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnReadAndProcessFile);
            Controls.Add(rbTime);
            Controls.Add(rbCountLines);
            Controls.Add(btnLoadFile);
            Controls.Add(txtFilePath);
            Controls.Add(label1);
            Name = "TextFileCounter";
            Text = "TextFileCounter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFilePath;
        private Button btnLoadFile;
        private RichTextBox rbCountLines;
        private RichTextBox rbTime;
        private Button btnReadAndProcessFile;
        private Label label2;
        private Label label3;
        private ListBox lbResults;
        private ListBox lbTop50;
        private ListBox lbTop50less6;
    }
}
