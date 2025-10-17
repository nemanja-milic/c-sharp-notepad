using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        private FileManager FileManager;

        public Form1()
        {
            InitializeComponent();
            FileManager = new FileManager(MainRichTextBox);
        }


        private void ReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileManager.ReadFile(openFileDialog.FileName);
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            FileManager.SaveFile();
        }
    }
}
