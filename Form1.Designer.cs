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
            richTextBox1 = new RichTextBox();
            readFile = new Button();
            button2 = new Button();
            replaceSearchedText = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 62);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(818, 373);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // readFile
            // 
            readFile.Location = new Point(12, 12);
            readFile.Name = "readFile";
            readFile.Size = new Size(94, 29);
            readFile.TabIndex = 1;
            readFile.Text = "Read file";
            readFile.UseVisualStyleBackColor = true;
            readFile.Click += ReadFile_Click;
            // 
            // button2
            // 
            button2.Location = new Point(736, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // replaceSearchedText
            // 
            replaceSearchedText.Location = new Point(426, 16);
            replaceSearchedText.Name = "replaceSearchedText";
            replaceSearchedText.Size = new Size(163, 29);
            replaceSearchedText.TabIndex = 6;
            replaceSearchedText.Text = "Replace";
            replaceSearchedText.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 17);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 27);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 450);
            Controls.Add(textBox2);
            Controls.Add(replaceSearchedText);
            Controls.Add(button2);
            Controls.Add(readFile);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button readFile;
        private Button button2;
        private Button replaceSearchedText;
        private TextBox textBox2;
    }
}
