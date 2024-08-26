using System.Text.RegularExpressions;

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
        /// this method loads a file of your choice
        /// </summary>
        /// <param name="sender">the object that makes the call</param>
        /// <param name="e">the event argument</param>
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
        /// this method just handles error messages
        /// </summary>
        /// <param name="ex">the exception type that has been called</param>
        private void ErrorHandler(Exception ex)
        {
            MessageBox.Show($"you have encountered a {ex}", "Error Message",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// this method well it handles everything
        /// </summary>
        /// <param name="sender">the object that makes the call</param>
        /// <param name="e">the event argument</param>
        private void btnReadAndProcessFile_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    var Start = DateTime.Now;
                    string line = File.ReadAllText(filePath);
                    lbResults.Text = line;
                    Regex regex = new Regex("[^a-zA-Z0-9]");
                    line = regex.Replace(line, " ");
                    var wordCount = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount = wordCount.Where(w => !string.IsNullOrWhiteSpace(w)).ToArray();
                    rbCountLines.Text = $"Lines in File: {File.ReadAllText(filePath).Count() + 1}" +
                        $"{Environment.NewLine}words in file: {wordCount.Count() + 1}";
                    Dictionary<string, int> frequancies = new Dictionary<string, int>();
                    foreach (string word in wordCount)
                    {
                        if (frequancies.ContainsKey(word))
                        {
                            frequancies[word] += 1;
                        }
                        else
                        {
                            frequancies[word] = 1;
                        }
                    }
                    foreach (KeyValuePair<string, int> entry in frequancies)
                    {
                        string word = entry.Key;
                        int frequancy = entry.Value;
                    }
                    var list = frequancies.OrderByDescending(x => x.Value).Take(50);
                    foreach (var word in list)
                    {
                        lbTop50.Items.Add($"{word.Key} Occured: {word.Value} Times");
                    }
                    var list2 = frequancies.OrderByDescending(x => x.Key.Length > 6).Take(50);
                    foreach (var word in list2)
                    {
                        lbTop50less6.Items.Add($"{word.Key} Occured: {word.Value} Times");
                    }
                    var stop = DateTime.Now;
                    var totatlTime = stop - Start;
                    rbTime.Text = $"Start Time: {Start.ToString("HH:mm:ss")}{Environment.NewLine}" +
                        $"End Time: {stop.ToString("HH:mm:ss")}{Environment.NewLine}" +
                        $"Overal Process Time: {totatlTime.TotalSeconds}";
                    MessageBox.Show($"Processing and counts completed! " +
                        $"{Environment.NewLine}{totatlTime.TotalSeconds} Seconds");
                }
                catch(IOException ex)
                {
                    ErrorHandler(ex);
                }
            }
            catch(FileNotFoundException ex)
            {
                ErrorHandler(ex);
            }
        }
    }
}
