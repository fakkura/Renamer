using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace Renamer
{
    public partial class Form1 : Form
    {
        private static Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public static string RandomString()
        {
            int length = random.Next(10, 21);
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void pathText_Click(object sender, EventArgs e)
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
                if (folderDialog.SelectedPath != string.Empty)
                {
                    pathText.Text = folderDialog.SelectedPath;
                    fileList.Files.Clear();
                    startButton.Text = "start";
                }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (startButton.Text == "start")
            {
                if (Directory.Exists(pathText.Text))
                {
                    startButton.Enabled = false;
                    fileList.SearchCriteria = pathText.Text + "\\*.*";
                    fileList.BeginSearch();
                    pathText.Enabled = false;
                    startButton.Text = "searching..";
                }
            }
            else
            {
                Parallel.ForEach(this.fileList.Files.Cast<object>(),
                new ParallelOptions { MaxDegreeOfParallelism = 1 },
                (file) =>
                {
                    string original = file.ToString();
                    string path = Path.GetDirectoryName(original);
                    string name = RandomString();
                    string extension = Path.GetExtension(original);
                    string renamed = path + "\\" + name + extension;
                    while(File.Exists(renamed))
                    {
                        name = RandomString();
                        renamed = path + "\\" + name + extension;
                    }
                    //File.AppendAllText("C:\\files.txt", original + " : " + renamed + Environment.NewLine);
                    try
                    {
                        if(File.Exists(original) && !File.Exists(renamed))
                            File.Move(original, renamed);
                    }
                    catch (Exception) { }
                });
                pathText.Text = "renamed";
            }
        }

        private void fileList_SearchComplete(object sender, EventArgs e)
        {
            pathText.Enabled = true;
            pathText.Text = "completed";
            startButton.Enabled = true;
            startButton.Text = "rename";
        }
    }
}
