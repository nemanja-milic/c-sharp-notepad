namespace Notepad
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
            MainRichTextBox = new RichTextBox();
            readFile = new Button();
            SaveChanges = new Button();
            replaceSearchedText = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // MainRichTextBox
            // 
            MainRichTextBox.Location = new Point(10, 46);
            MainRichTextBox.Margin = new Padding(3, 2, 3, 2);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.Size = new Size(716, 281);
            MainRichTextBox.TabIndex = 0;
            MainRichTextBox.Text = "";
            // 
            // readFile
            // 
            readFile.Location = new Point(10, 9);
            readFile.Margin = new Padding(3, 2, 3, 2);
            readFile.Name = "readFile";
            readFile.Size = new Size(82, 22);
            readFile.TabIndex = 1;
            readFile.Text = "Read file";
            readFile.UseVisualStyleBackColor = true;
            readFile.Click += ReadFile_Click;
            // 
            // SaveChanges
            // 
            SaveChanges.Location = new Point(644, 9);
            SaveChanges.Margin = new Padding(3, 2, 3, 2);
            SaveChanges.Name = "SaveChanges";
            SaveChanges.Size = new Size(82, 22);
            SaveChanges.TabIndex = 2;
            SaveChanges.Text = "Save ";
            SaveChanges.UseVisualStyleBackColor = true;
            SaveChanges.Click += SaveChanges_Click;
            // 
            // replaceSearchedText
            // 
            replaceSearchedText.Location = new Point(373, 12);
            replaceSearchedText.Margin = new Padding(3, 2, 3, 2);
            replaceSearchedText.Name = "replaceSearchedText";
            replaceSearchedText.Size = new Size(143, 22);
            replaceSearchedText.TabIndex = 6;
            replaceSearchedText.Text = "Replace";
            replaceSearchedText.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 13);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 338);
            Controls.Add(textBox2);
            Controls.Add(replaceSearchedText);
            Controls.Add(SaveChanges);
            Controls.Add(readFile);
            Controls.Add(MainRichTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox MainRichTextBox;
        private Button readFile;
        private Button SaveChanges;
        private Button replaceSearchedText;
        private TextBox textBox2;
    }
}
