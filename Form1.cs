using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using SharpCompress.Archives.SevenZip;
using SharpCompress.Common;
using SharpCompress.Readers;


namespace Passfinder
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        static async Task GenerateCounter(List<char> elements, HashSet<string> uniqueCombinations, string current, int maxLength, ProgressBar progressBar)
        {
            
            if (current.Length > 0)
            {
                uniqueCombinations.Add(current);
                // Update progress bar value
                
            }

            if (current.Length == maxLength)
            {
                return;
            }

            foreach (char element in elements)
            {
                
                // Generate combinations recursively
                await GenerateCounter(elements, uniqueCombinations, current + element, maxLength, progressBar);
                progressBar.Value = uniqueCombinations.Count;
            }
        }


        public static bool ExtractArciveFile(string archiveFilePath, string extractPath, string password)
        {
            try
            {
                using var archive = ArchiveFactory.Open(archiveFilePath, new ReaderOptions { Password = password });
                foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                {
                    entry.WriteToDirectory(extractPath, new ExtractionOptions()
                    {
                        ExtractFullPath = true,
                        Overwrite = true
                    });
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        static readonly string main_dir = AppContext.BaseDirectory;
        static readonly string filePath = Path.Combine(main_dir, "counter_results.txt");


        private async void Generate_Click(object sender, EventArgs e)
        {

            int pos = int.Parse(positions.Text.ToString());
            List<char> passinput = [];
            List<string> passoutput = [];
            

            char[] char_k = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K',
                'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'];

            char[] char_s = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];

            char[] num = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];

            if (alphabetic_k.Checked)
            {
                foreach (char c in char_k)
                {
                    passinput.Add(c);
                }
            }
            if (alphabetic_s.Checked)
            {
                foreach (char c in char_s)
                {
                    passinput.Add(c);
                }
            }
            if (numerals.Checked)
            {
                foreach (char c in num)
                {
                    passinput.Add(c);
                }
            }
            if (white_space.Checked)
            {
                passinput.Add(' ');
            }

            // read from the checkbox to the collactor
            for (int i = 0; i < accented_latters_box.Items.Count; i++)
            {
                if (accented_latters_box.GetItemChecked(i) == true)
                {
                    passinput.Add(((string)accented_latters_box.Items[i])[0]);
                }
            }

            for (int i = 0; i < greek_letters_box.Items.Count; i++)
            {
                if (greek_letters_box.GetItemChecked(i) == true)
                {
                    passinput.Add(((string)greek_letters_box.Items[i])[0]);
                }
            }

            for (int i = 0; i < mathematical_symbols_box.Items.Count; i++)
            {
                if (mathematical_symbols_box.GetItemChecked(i) == true)
                {
                    passinput.Add(((string)mathematical_symbols_box.Items[i])[0]);
                }
            }

            for (int i = 0; i < special_symbols_box.Items.Count; i++)
            {
                if (special_symbols_box.GetItemChecked(i) == true)
                {
                    passinput.Add(((string)special_symbols_box.Items[i])[0]);
                }
            }

            for (int i = 0; i < currency_symbols_box.Items.Count; i++)
            {
                if (currency_symbols_box.GetItemChecked(i) == true)
                {
                    passinput.Add(((string)currency_symbols_box.Items[i])[0]);
                }
            }

            // remove any exceptions if needed
            string exceptions_latters = exceptions.Text;

            for (int i = 0; i < exceptions_latters.Length; i++)
            {
                for (int j = 0; j < passinput.Count; j++)
                {
                    if (exceptions_latters[i] == passinput[j])
                    {
                        passinput.RemoveAt(j);
                    }
                }
            }

            // sorting and saving to a txt file
            int total = 0;
            for( int i =1; i<= pos; i++)
            {
                total += (int)Math.Pow(passinput.Count, i);
            }
            HashSet<string> uniqueCombinations = [];
            progressBar1.Minimum = 0;
            progressBar1.Maximum = total;
            // Generate the counter
            await GenerateCounter(passinput, uniqueCombinations, "", pos, progressBar1);

            // Sort the unique combinations first by position, then alphabetically
            List<string> sortedCombinations = [.. uniqueCombinations
                .OrderBy(s => s.Length)
                .ThenBy(s => s)];
            // Write the sorted unique combinations to the file
            File.WriteAllLines(filePath, sortedCombinations);


            /////////////////////////////////////////

        }

        private void Run_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            string archiveFilePath = archive_path.Text;

            if (!File.Exists(archiveFilePath))
            {
                if (zip.Checked) {
                    archiveFilePath += ".zip";
                }
                else if (rar.Checked)
                {
                    archiveFilePath += ".rar";
                }
                else if (szip.Checked)
                {
                    archiveFilePath += ".7zip";
                }
                else if (sz.Checked)
                {
                    archiveFilePath += ".7z";
                }
                else if (unrar.Checked)
                {
                    archiveFilePath += ".unrar";
                }
                else if (unzip.Checked)
                {
                    archiveFilePath += ".unzip";
                }
                else if (bzip2.Checked)
                {
                    archiveFilePath += ".bzip2";
                }
                else if (gzip.Checked)
                {
                    archiveFilePath += ".gzip";
                }
                else if (tar.Checked)
                {
                    archiveFilePath += ".tar";
                }
                else if (lzip.Checked)
                {
                    archiveFilePath += ".lzip";
                }
                else if (xz.Checked)
                {
                    archiveFilePath += ".xz";
                }
            }

            if (File.Exists(archiveFilePath))

            {

                string extractPath = archiveFilePath.Split(".")[0];
                if (!Directory.Exists(extractPath))
                {
                    Directory.CreateDirectory(extractPath);
                }

                // read file
                if (File.Exists(filePath))
                {
                    reader = new StreamReader(filePath);

                    string? line;
                    // Read and display lines from the file until the end of the file is reached
                    while ((line = reader.ReadLine()) != null)
                    {
                        bool success = ExtractArciveFile(archiveFilePath, extractPath, line);
                        if (success)
                        {
                            pass.Text = line;
                            MessageBox.Show($"The correct Password was: {line}");
                            break;
                        }
                        //System.Diagnostics.Debug.WriteLine(line);
                    }
                    reader.Close();
                }
                else { MessageBox.Show("please Provide a txt file or use the Generate button to make one"); }
            }
            else { MessageBox.Show("please enter a correct archive name/directory"); }
            
        }
    }
}
