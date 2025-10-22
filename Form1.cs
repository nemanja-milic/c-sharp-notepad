using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        private FileManager FileManager;

        public Form1()
        {
            InitializeComponent();
            FileManager = new FileManager();
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
                FileManager.FileOpened();
                MainRichTextBox.Text = FileManager.ReadFile(openFileDialog.FileName);
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if(FileManager.isNewFile())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Error while opening file dialog, please try again");
                    return;
                }
                FileManager.FilePath = saveFileDialog.FileName;
                FileManager.SaveFile(MainRichTextBox.Text);
            }
            else FileManager.SaveFile(MainRichTextBox.Text);
        }
    }
}
