using SharpCompress.Archives;
using SharpCompress.Common;
using SharpCompress.Readers;


namespace Passfinder
{
    public partial class Form1 : Form
    {
        private readonly Generate gen = new();
        private readonly Runn start_run = new();
        private bool isGenerating = false;
        private bool isCanceling = false;

        public Form1()
        {
            InitializeComponent();
            if (gen_file_textbox.Text.Contains("") == true)
            {
                gen_file_textbox.Text = Path.Combine(AppContext.BaseDirectory, "counter_results.txt");
            }

            FormClosing += Closing_Form!;
        }

        private void UpdateUI(double processedCombinations)
        {
            progress_textBox.Text = $"{Math.Round(processedCombinations,12)}%";
            progressBar1.Value = (int)processedCombinations;
        }

        private void Closing_Form(object sender, FormClosingEventArgs e)
        {
            gen.Cancel(true);
            start_run.Cancel(true);
        }

        private async void Generate_Click(object sender, EventArgs e)
        {
            int pos_start = int.Parse(positions_min.Text.ToString());
            int pos_last = int.Parse(positions_max.Text.ToString());
            List<char> passinput = [];

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

            string exceptions_latters = exceptions_textbox.Text;

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

            isCanceling = gen.Cancel(false);
            progressBar1.Value = 0;
            var progress = new Progress<double>(value => UpdateUI(value));
            generate.Enabled = run.Enabled = false;
            generating_textBox.Text = "in Progress...";
            isGenerating = true;
            await gen.GenerateCombinations(passinput, gen_file_textbox.Text, pos_start, pos_last, progress);
            isGenerating = false;
            if (!isGenerating && !isCanceling) { generating_textBox.Text = "Done"; }
            generate.Enabled = run.Enabled = true;
        }

        private async void Run_Click(object sender, EventArgs e)
        {
            string archive_path = archive_path_textbox.Text;
            string Etension_Name = start_run.Check_archive(archive_path);

            if (Etension_Name == ".zip") { zip.Checked = true; }
            else if (Etension_Name == ".rar") { rar.Checked = true; }
            else if (Etension_Name == ".7zip") { szip.Checked = true; }
            else if (Etension_Name == ".7z") { sz.Checked = true; }
            else if (Etension_Name == ".unrar") { unrar.Checked = true; }
            else if (Etension_Name == ".unzip") { unzip.Checked = true; }
            else if (Etension_Name == ".bzip2") { bzip2.Checked = true; }
            else if (Etension_Name == ".gzip") { gzip.Checked = true; }
            else if (Etension_Name == ".tar") { tar.Checked = true; }
            else if (Etension_Name == ".lzip") { lzip.Checked = true; }
            else if (Etension_Name == ".xz") { xz.Checked = true; }

            else if (Etension_Name == "Unknown_File")
            {
                if (zip.Checked) { archive_path += ".zip"; }
                else if (rar.Checked) { archive_path += ".rar"; }
                else if (szip.Checked) { archive_path += ".7zip"; }
                else if (sz.Checked) { archive_path += ".7z"; }
                else if (unrar.Checked) { archive_path += ".unrar"; }
                else if (unzip.Checked) { archive_path += ".unzip"; }
                else if (bzip2.Checked) { archive_path += ".bzip2"; }
                else if (gzip.Checked) { archive_path += ".gzip"; }
                else if (tar.Checked) { archive_path += ".tar"; }
                else if (lzip.Checked) { archive_path += ".lzip"; }
                else if (xz.Checked) { archive_path += ".xz"; }
            }
            else if (Etension_Name == "Unknown_Extension")
            {
                MessageBox.Show("Please check the file Extension");
            }

            if (start_run.Correct_Extension(archive_path))
            {
                pass_textBox.Text = "In Progress...";

                listTextBox.Clear();
                progressBar1.Value = 0;

                generate.Enabled = run.Enabled = start_run.Cancel(false);
                await start_run.Open_archive(archive_path, gen_file_textbox.Text, pass_textBox, listTextBox, progressBar1);
                generate.Enabled = run.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please provid/check the correct Extension");
            }
        }

        private void Positions_min_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void Positions_min_TextChanged(object sender, EventArgs e)
        {
            if (positions_min.Text == "")
            {
                positions_min.Text = "1";
            }
            if (int.Parse(positions_min.Text) > int.Parse(positions_max.Text))
            {
                positions_max.Text = positions_min.Text;
            }
        }

        private void Positions_max_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void Positions_max_TextChanged(object sender, EventArgs e)
        {
            if (positions_max.Text == "")
            {
                positions_max.Text = "1";
            }
            if (int.Parse(positions_min.Text) > int.Parse(positions_max.Text))
            {
                positions_min.Text = positions_max.Text;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            if (isGenerating && gen.Cancel(true))
            {
                generating_textBox.Text = "Canceled";
                isCanceling = true;
            }

            start_run.Cancel(true);
        }
    }
}


class Runn
{
    private readonly string[] validExtensions = [ ".zip", ".rar", ".7zip", ".7z",
                                                  ".unrar", ".unzip", ".bzip2",
                                                  ".gzip", ".tar", ".lzip", ".xz" ];
    private string line = string.Empty;
    private readonly object syncObject = new();
    private bool cancelling = false;
    private double total_attempts;
    private double pass_attempt;
    private double progress_attempts;
    private string correct_password = string.Empty;
    private bool iscorrect_extension;

    public string Check_archive(string archiveFilePath)
    {
        if (File.Exists(archiveFilePath) && Path.HasExtension(archiveFilePath))
        {
            foreach (string extension in validExtensions)
            {

                if (Path.GetExtension(archiveFilePath).Equals(extension, StringComparison.OrdinalIgnoreCase))
                {
                    return extension;
                }
            }
            return "Unknown_Extension";
        }
        return "Unknown_File";
    }

    public bool Correct_Extension(string archiveFilePath)
    {
        iscorrect_extension = false;
        try
        {
            using var archive = ArchiveFactory.Open(archiveFilePath);
            iscorrect_extension = true;
        }
        catch { iscorrect_extension = false; }
        return iscorrect_extension;
    }

    public async Task Open_archive(string archiveFilePath, string password_file, TextBox pass, RichTextBox listTextBox, ProgressBar progressBar)
    {

        StreamReader reader;

        string extractPath = archiveFilePath.Replace(Path.GetExtension(archiveFilePath), string.Empty);

        if (!Directory.Exists(extractPath))
        {
            Directory.CreateDirectory(extractPath);
        }

        if (Password_needed(archiveFilePath))
        {
            if (File.Exists(password_file))
            {

                pass_attempt = 0;
                total_attempts = File.ReadAllLines(password_file).Length;
                progress_attempts = 0;

                reader = new StreamReader(password_file);

                while ((line = reader.ReadLine()!) != null)
                {
                    if (await Check_Password(archiveFilePath, line))
                    {


                        correct_password = line;
                        pass.Text = "Extracting...";
                        await ExtractArciveFile(archiveFilePath, extractPath);
                        reader.Close();
                        pass.Text = line;
                        progressBar.Value = progressBar.Maximum;
                        return;
                    }

                    if (!listTextBox.IsDisposed)
                    {
                        listTextBox.AppendText(line + "\n");

                    }
                    lock (syncObject)
                    {
                        if (cancelling)
                        {
                            pass.Text = "the Process was Calnceled";
                            return;
                        }
                    }
                    pass_attempt++;
                    progress_attempts = (pass_attempt / total_attempts) * 100;
                    System.Diagnostics.Debug.WriteLine((int)progress_attempts);
                    progressBar.Value = (int)progress_attempts;
                }
                reader.Close();
            }

            else
            {
                pass.Text = "please Provide a txt file or use the Generate button to make one";
            }
        }
        else
        {
            await ExtractArciveFile(archiveFilePath, extractPath);
            pass.Text = "no password needed";
        }
        pass.Text = "no fit password was found";

    }


    public static bool Password_needed(string archiveFilePath)
    {
        try
        {
            using var archive = ArchiveFactory.Open(archiveFilePath);
            foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
            {
                return entry.IsEncrypted;
            }
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static Task<bool> Check_Password(string archiveFilePath, string password)
    {
        return Task.Run(() =>
        {
            bool iscorrect_password = false;
            using var archive = ArchiveFactory.Open(archiveFilePath, new ReaderOptions { Password = password });

            var entry = archive.Entries.GetEnumerator();

            if (entry.MoveNext())
            {
                try
                {
                    using var stream = entry.Current.OpenEntryStream();
                    byte[] buffer = new byte[1];
                    stream.Read(buffer, 0, buffer.Length);

                    iscorrect_password = true;
                }
                catch (CryptographicException)
                {
                    iscorrect_password = false;
                }
            }
            return iscorrect_password;
        });
    }
    public Task<bool> ExtractArciveFile(string archiveFilePath, string extractPath)
    {
        return Task.Run(() =>
        {
            bool success = false;
            using var archive = ArchiveFactory.Open(archiveFilePath, new ReaderOptions { Password = correct_password });

            try
            {
                foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                {
                    entry.WriteToDirectory(extractPath, new ExtractionOptions()
                    {
                        ExtractFullPath = true,
                        Overwrite = true
                    });
                }
                success = true;
            }
            catch (CryptographicException)
            {
                success = false;
            }
            return success;
        });
    }

    public bool Cancel(bool req)
    {
        lock (syncObject)
        {
            cancelling = req;
        }
        return cancelling;
    }
}

class Generate
{
    private bool cancelling = false;
    private readonly object syncObject = new();
    private double processedCombinations;
    private List<char> elements = [];
    private string outputFilePath = string.Empty;
    private int minLength;
    private int maxLength;
    private double percentage;

    public async Task GenerateCombinations(
            List<char> elements,
            string outputFilePath,
            int minLength,
            int maxLength,
            IProgress<double> progress)
    {
        this.elements = elements;
        this.outputFilePath = outputFilePath;
        this.minLength = minLength;
        this.maxLength = maxLength;

        File.WriteAllText(outputFilePath, string.Empty);

        processedCombinations = 0;
        percentage = 0;

        for (int i = this.minLength; i <= this.maxLength; i++)
        {
            await Task.Run(() => GenerateCombinations(i, progress));
        }
        return;
    }

    private Task GenerateCombinations(int length, IProgress<double> progress)
    {
        double totalCombinations = Math.Pow(elements.Count, length);
        double charCount = elements.Count;


        for (double i = 0; i < totalCombinations; i++)
        {
            char[] combination = new char[length];
            double index = i;
            for (int j = 0; j < length; j++)
            {
                combination[j] = elements[(int)(index % charCount)];
                index /= charCount;
            }
            
            percentage = ((i+1) / totalCombinations) * 100.0;
            System.Diagnostics.Debug.WriteLine($"Processed combinations: {i}");
            progress.Report(percentage);
            SaveToFile(new string(combination));
            lock (syncObject)
            {
                if (cancelling)
                {
                    break;
                }
            }
        }
        return Task.CompletedTask;
    }

    public void SaveToFile(string combination)
    {
        using StreamWriter sw = new(outputFilePath, true);
        sw.WriteLineAsync(combination);
    }

    public bool Cancel(bool req)
    {
        lock (syncObject)
        {
            cancelling = req;
        }
        return cancelling;
    }

}

