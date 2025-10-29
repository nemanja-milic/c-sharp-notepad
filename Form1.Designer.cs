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
            mainRichTextBox = new RichTextBox();
            readFile = new Button();
            SaveChanges = new Button();
            btnReplace = new Button();
            inputReplace = new TextBox();
            inputSearch = new TextBox();
            btnSearch = new Button();
            btnCancelSearch = new Button();
            SuspendLayout();
            // 
            // mainRichTextBox
            // 
            mainRichTextBox.Location = new Point(12, 127);
            mainRichTextBox.Name = "mainRichTextBox";
            mainRichTextBox.Size = new Size(818, 373);
            mainRichTextBox.TabIndex = 0;
            mainRichTextBox.Text = "";
            mainRichTextBox.KeyDown += openSearch;
            // 
            // readFile
            // 
            readFile.Location = new Point(11, 12);
            readFile.Name = "readFile";
            readFile.Size = new Size(94, 29);
            readFile.TabIndex = 1;
            readFile.Text = "Read file";
            readFile.UseVisualStyleBackColor = true;
            readFile.Click += ReadFile_Click;
            // 
            // SaveChanges
            // 
            SaveChanges.Location = new Point(736, 12);
            SaveChanges.Name = "SaveChanges";
            SaveChanges.Size = new Size(94, 29);
            SaveChanges.TabIndex = 2;
            SaveChanges.Text = "Save ";
            SaveChanges.UseVisualStyleBackColor = true;
            SaveChanges.Click += SaveChanges_Click;
            // 
            // btnReplace
            // 
            btnReplace.Location = new Point(230, 80);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(163, 29);
            btnReplace.TabIndex = 6;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // inputReplace
            // 
            inputReplace.Location = new Point(12, 82);
            inputReplace.Name = "inputReplace";
            inputReplace.Size = new Size(201, 27);
            inputReplace.TabIndex = 7;
            // 
            // inputSearch
            // 
            inputSearch.Location = new Point(12, 49);
            inputSearch.Name = "inputSearch";
            inputSearch.Size = new Size(201, 27);
            inputSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(230, 45);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(163, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancelSearch
            // 
            btnCancelSearch.Location = new Point(429, 66);
            btnCancelSearch.Name = "btnCancelSearch";
            btnCancelSearch.Size = new Size(163, 29);
            btnCancelSearch.TabIndex = 10;
            btnCancelSearch.Text = "Cancel";
            btnCancelSearch.UseVisualStyleBackColor = true;
            btnCancelSearch.Click += btnCancelSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 512);
            Controls.Add(btnCancelSearch);
            Controls.Add(btnSearch);
            Controls.Add(inputSearch);
            Controls.Add(inputReplace);
            Controls.Add(btnReplace);
            Controls.Add(SaveChanges);
            Controls.Add(readFile);
            Controls.Add(mainRichTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox mainRichTextBox;
        private Button readFile;
        private Button SaveChanges;
        private Button btnReplace;
        private TextBox inputReplace;
        private TextBox inputSearch;
        private Button btnSearch;
        private Button btnCancelSearch;
    }
}
