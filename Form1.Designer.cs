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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            btnReadAndProcessFile = new Button();
            rtxtTop50Words = new RichTextBox();
            rtxtTop50Wordsless6 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
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
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(12, 38);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(213, 152);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Enabled = false;
            richTextBox2.Location = new Point(235, 38);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(213, 152);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            // 
            // btnReadAndProcessFile
            // 
            btnReadAndProcessFile.Location = new Point(454, 40);
            btnReadAndProcessFile.Name = "btnReadAndProcessFile";
            btnReadAndProcessFile.Size = new Size(148, 150);
            btnReadAndProcessFile.TabIndex = 5;
            btnReadAndProcessFile.Text = "Read and Process File";
            btnReadAndProcessFile.UseVisualStyleBackColor = true;
            // 
            // rtxtTop50Words
            // 
            rtxtTop50Words.Location = new Point(618, 40);
            rtxtTop50Words.Name = "rtxtTop50Words";
            rtxtTop50Words.Size = new Size(196, 398);
            rtxtTop50Words.TabIndex = 6;
            rtxtTop50Words.Text = "";
            // 
            // rtxtTop50Wordsless6
            // 
            rtxtTop50Wordsless6.Location = new Point(842, 38);
            rtxtTop50Wordsless6.Name = "rtxtTop50Wordsless6";
            rtxtTop50Wordsless6.Size = new Size(189, 400);
            rtxtTop50Wordsless6.TabIndex = 7;
            rtxtTop50Wordsless6.Text = "";
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
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 196);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(590, 274);
            listBox1.TabIndex = 10;
            // 
            // TextFileCounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 490);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rtxtTop50Wordsless6);
            Controls.Add(rtxtTop50Words);
            Controls.Add(btnReadAndProcessFile);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
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
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button btnReadAndProcessFile;
        private RichTextBox rtxtTop50Words;
        private RichTextBox rtxtTop50Wordsless6;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
    }
}
