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
        private string FilePath;

        public FileManager(string filePath)
        {
            FileText = "";
            FilePath = filePath;
        }
        public string ReadFile()
        {
            if (!File.Exists(FilePath)) MessageBox.Show("File does not exist");
            using (StreamReader reader = new StreamReader(FilePath))
            {
                FileText = reader.ReadToEnd();
                Console.WriteLine(FileText);

            }
            return FileText;
        }

        public void SaveFile(string fileText) 
        {
            if (!File.Exists(FilePath))
            {
                // show message box and ask user to enter filename
            }
            using(StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.Write(fileText);
            }
        }
    }
}
