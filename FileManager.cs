using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    internal class FileManager
    {
        private string FileText;
        private RichTextBox MainTextBox;

        public FileManager(RichTextBox mainTextBox)
        {
            FileText = "";
            MainTextBox = mainTextBox;
        }
        public void ReadFile(string path)
        {
            if (!File.Exists(path)) MessageBox.Show("File does not exist");
            using (StreamReader reader = new StreamReader(path))
            {
                FileText = reader.ReadToEnd();
                MainTextBox.Text = FileText;
            }
            MainTextBox.Text = FileText;
        }

        public void SaveFile() 
        {

        }
    }
}
