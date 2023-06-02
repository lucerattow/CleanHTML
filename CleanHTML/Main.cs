namespace CleanHTML
{
    public partial class Main : Form
    {
        private string _folderPath;

        public Main()
        {
            InitializeComponent();
        }

        private void loadFiles()
        {
            var files = Directory.GetFiles(_folderPath);
            lvFiles.Items.Clear();

            foreach (var file in files)
            {
                var p = Path.GetExtension(file).ToLower();
                if (Path.GetExtension(file).ToLower() == ".html")
                    lvFiles.Items.Add(file);
            }
        }

        private void CleanHtml(string filePath)
        {
            var content = File.ReadAllText(filePath);

            var startPosition = content.IndexOf($"<{txtTag}");
            var endPosition = content.IndexOf($"</{txtTag}>");

            if (startPosition != -1 && endPosition != -1)
            {
                var endContent = content.Substring(startPosition, endPosition + 9 - startPosition);

                var outputFolder = Path.GetDirectoryName(filePath) + @"\output\";

                OutputFolderEnsureCreated(outputFolder);

                var newFilePath = outputFolder + Path.GetFileName(filePath);

                File.WriteAllText(newFilePath, endContent);
            }
        }

        private void OutputFolderEnsureCreated(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                _folderPath = folderBrowserDialog.SelectedPath;
                loadFiles();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvFiles.Items)
            {
                if (item.Checked)
                    CleanHtml(item.Text);
            }

            MessageBox.Show("Archivos exportados exitosamente!");
        }
    }
}