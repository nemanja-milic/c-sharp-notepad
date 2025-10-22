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
        public string FileText { get; set; } 
        public string FilePath { get; set; } 
        private bool NewFile = true;

        public bool isNewFile() { return NewFile; }
        public void FileOpened() { NewFile = false; }

        public string ReadFile(string filePath)
        {
            if (!File.Exists(filePath)) MessageBox.Show("File does not exist");
            FilePath = filePath;
            using (StreamReader reader = new StreamReader(filePath))
            {
                FileText = reader.ReadToEnd();
            }
            return FileText;
        }

        public void SaveFile(string fileText) 
        {
            
            using(StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.Write(fileText);
            }
        }
    }
}
