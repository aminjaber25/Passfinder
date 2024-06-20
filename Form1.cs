using SharpCompress.Archives;
using SharpCompress.Common;
using SharpCompress.Readers;

namespace Passfinder
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            if (gen_file.Text.Contains("") == true)
            {
                gen_file.Text = Path.Combine(AppContext.BaseDirectory, "counter_results.txt"); 
            }
        }

        

        private readonly Generate gen = new();

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

            gen.Cancel(false);

            if (File.Exists(gen_file.Text))
            {
                if (Path.GetExtension(gen_file.Text).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    System.Diagnostics.Debug.WriteLine("START");
                    await Task.Run(() => gen.GenerateCombinations(passinput, gen_file.Text, pos_start, pos_last));
                    System.Diagnostics.Debug.WriteLine("DONE");
                }
                else
                {
                    gen.Cancel(true);
                }
            }
            else
            {
                gen.Cancel(true);
            }

            
            

        }

        private void Run_Click(object sender, EventArgs e)
        {
            string[] validExtensions = [ ".zip", ".rar", ".7zip", ".7z",
            ".unrar", ".unzip", ".bzip2",
            ".gzip", ".tar", ".lzip", ".xz" ];
            string filePath = @"C:\Users\Jamen\Downloads\OneDrive-2024-06-06\合集\a";

            if (Runn.Check_archive(filePath, validExtensions) == "Unknown")
            {
                if (zip.Checked) { filePath += ".zip"; }
                else if (rar.Checked) { filePath += ".rar"; }
                else if (szip.Checked) { filePath += ".7zip"; }
                else if (sz.Checked) { filePath += ".7z"; }
                else if (unrar.Checked) { filePath += ".unrar"; }
                else if (unzip.Checked) { filePath += ".unzip"; }
                else if (bzip2.Checked) { filePath += ".bzip2"; }
                else if (gzip.Checked) { filePath += ".gzip"; }
                else if (tar.Checked) { filePath += ".tar"; }
                else if (lzip.Checked) { filePath += ".lzip"; }
                else if (xz.Checked) { filePath += ".xz"; }

            }
            
            pass.Text = Runn.Unpacking(filePath, gen_file.Text);

            /*if (File.Exists(archiveFilePath))
            {
                pass.Text = "In Progress...";
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
*/
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
            gen.Cancel(true);
        }
    }
}


class Runn
{
    public static string Check_archive(string archiveFilePath, string[] validExtensions)
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
        }
        return "Unknown";
    }

    public static string Unpacking(string archiveFilePath, string password_file)
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
                reader = new StreamReader(password_file);

                string? line;
                // Read and display lines from the file until the end of the file is reached
                while ((line = reader.ReadLine()) != null)
                {
                    bool success = ExtractArciveFile(archiveFilePath, extractPath, line);
                    if (success)
                    {
                        reader.Close();
                        return line;

                    }
                    System.Diagnostics.Debug.WriteLine(line);
                    Console.WriteLine(line);
                }
                reader.Close();
            }

            else { return "please Provide a txt file or use the Generate button to make one"; }
        }
        else
        {
            ExtractArciveFile(archiveFilePath, extractPath);
            return "";
        }
        return "no fit password was found";

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
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}");
            return false;
        }
    }
    public static bool ExtractArciveFile(string archiveFilePath, string extractPath, string password = "")
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
            return false;
        }
    }
}

class Generate
{
    public Generate() { }

    private bool cancelling = false;
    private readonly object syncObject = new();
    public void GenerateCombinations(
            List<char> elements,
            string outputFilePath,
            int minLength,
            int maxLength)
    {
        // Initialize or clear the output file
        File.WriteAllText(outputFilePath, string.Empty);

        long processedCombinations = 0;

        for (int i = minLength; i <= maxLength; i++)
        {
            void ProcessCombinations(string prefix, int length)
            {
                if (length == 0)
                {
                    SaveToFile(outputFilePath, prefix);
                    processedCombinations++;
                    System.Diagnostics.Debug.WriteLine($"Processed combinations: {processedCombinations}");
                    return;
                }

                foreach (char element in elements)
                {
                    lock (syncObject)
                    {
                        if (cancelling) // Check for cancellation request within lock
                        {
                            break;
                        }
                    }
                    ProcessCombinations(prefix + element, length - 1);
                }
            }

            void SaveToFile(string filePath, string combination)
            {
                // Append combination to the output file
                using StreamWriter sw = new(filePath, true);
                sw.WriteLineAsync(combination);
            }

            // Start generating combinations
            ProcessCombinations("", i);
        }
    }
    public void Cancel(bool req)
    {
        lock (syncObject) // Use lock for thread-safe flag update
        {
            cancelling = req;
        }
    }

}

