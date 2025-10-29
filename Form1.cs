using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        private FileManager FileManager;

        public Form1()
        {
            InitializeComponent();
            HideSearch();
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
                mainRichTextBox.Text = FileManager.ReadFile(openFileDialog.FileName);
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if (FileManager.isNewFile())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show("Error while opening file dialog, please try again");
                    return;
                }
                FileManager.FilePath = saveFileDialog.FileName;
                FileManager.SaveFile(mainRichTextBox.Text);
            }
            else FileManager.SaveFile(mainRichTextBox.Text);
        }

        private void HideSearch()
        {
            btnSearch.Hide();
            inputSearch.Hide();
            inputReplace.Hide();
            btnReplace.Hide();
            btnCancelSearch.Hide();
        }

        private void openSearch(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                btnSearch.Show();
                inputReplace.Show();
                btnReplace.Show();
                inputSearch.Show();
                btnCancelSearch.Show();
            }
        }

        private void btnCancelSearch_Click(object sender, EventArgs e)
        {
            HideSearch();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // take value from inputSearch
            // take value from mainrichtextbox
            int start = 0;
            mainRichTextBox.SelectAll();
            mainRichTextBox.SelectionBackColor = Color.White; // clear old highlights

            while ((start = mainRichTextBox.Text.IndexOf(inputSearch.Text, start, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                mainRichTextBox.Select(start, inputSearch.Text.Length);
                mainRichTextBox.SelectionBackColor = Color.Yellow; // highlight match
                start += inputSearch.Text.Length;
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            // take value from inputSearch
            // take value from mainrichtextbox
            // go thru mainrichtextbox
            // if(word )
            StringBuilder stringBuilder = new StringBuilder(mainRichTextBox.Text);
            stringBuilder.Replace(inputSearch.Text, inputReplace.Text);
            mainRichTextBox.Text = stringBuilder.ToString();
        }
    }
}
