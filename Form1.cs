namespace ReadFromText
{
    public partial class TextFileCounter : Form
    {
        public TextFileCounter()
        {
            InitializeComponent();
        }
        //this is the path to the file
        private string filePath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog chooseFile = new OpenFileDialog();
                chooseFile.ShowDialog();
                filePath = chooseFile.FileName;
                txtFilePath.Text = filePath;
            }
            catch (FileNotFoundException ex)
            {
                ErrorHandler(ex);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ex"></param>
        private void ErrorHandler(Exception ex)
        {
            MessageBox.Show($"you have encountered a {ex}", "Error Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReadAndProcessFile_Click(object sender, EventArgs e)
        {

        }
    }
}
