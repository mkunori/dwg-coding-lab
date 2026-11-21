namespace DwgCodingLab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                Filter = "DWG ファイル (*.dwg)|*.dwg",
                DefaultExt = "dwg",
                FileName = "line.dwg"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                LineDwgExporter.Export(dialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "DWG の保存に失敗しました");
                return;
            }

            MessageBox.Show(this, "DWG を保存しました。");
        }
    }
}
