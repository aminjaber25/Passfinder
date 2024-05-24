namespace Passfinder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            generate = new Button();
            alphabetic_s = new CheckBox();
            alphabetic_k = new CheckBox();
            positions_min = new TextBox();
            accented_latters_box = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            mathematical_symbols_box = new CheckedListBox();
            label4 = new Label();
            special_symbols_box = new CheckedListBox();
            label5 = new Label();
            currency_symbols_box = new CheckedListBox();
            label6 = new Label();
            greek_letters_box = new CheckedListBox();
            label7 = new Label();
            label8 = new Label();
            exceptions = new TextBox();
            label9 = new Label();
            white_space = new CheckBox();
            run = new Button();
            label10 = new Label();
            archive_path = new TextBox();
            zip = new RadioButton();
            panel1 = new Panel();
            xz = new RadioButton();
            lzip = new RadioButton();
            tar = new RadioButton();
            gzip = new RadioButton();
            bzip2 = new RadioButton();
            unzip = new RadioButton();
            unrar = new RadioButton();
            sz = new RadioButton();
            szip = new RadioButton();
            rar = new RadioButton();
            label11 = new Label();
            numerals = new CheckBox();
            label12 = new Label();
            pass = new Label();
            progressBar1 = new ProgressBar();
            positions_max = new TextBox();
            label13 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // generate
            // 
            generate.Location = new Point(239, 433);
            generate.Name = "generate";
            generate.Size = new Size(134, 46);
            generate.TabIndex = 0;
            generate.Text = "Generate";
            generate.UseVisualStyleBackColor = true;
            generate.Click += Generate_Click;
            // 
            // alphabetic_s
            // 
            alphabetic_s.AutoSize = true;
            alphabetic_s.Checked = true;
            alphabetic_s.CheckState = CheckState.Checked;
            alphabetic_s.Location = new Point(92, 58);
            alphabetic_s.Name = "alphabetic_s";
            alphabetic_s.Size = new Size(115, 19);
            alphabetic_s.TabIndex = 1;
            alphabetic_s.Text = "Alphabetic Small";
            alphabetic_s.UseVisualStyleBackColor = true;
            // 
            // alphabetic_k
            // 
            alphabetic_k.AutoSize = true;
            alphabetic_k.Checked = true;
            alphabetic_k.CheckState = CheckState.Checked;
            alphabetic_k.Location = new Point(92, 83);
            alphabetic_k.Name = "alphabetic_k";
            alphabetic_k.Size = new Size(122, 19);
            alphabetic_k.TabIndex = 2;
            alphabetic_k.Text = "Alphabetic Kapital";
            alphabetic_k.UseVisualStyleBackColor = true;
            // 
            // positions_min
            // 
            positions_min.Location = new Point(374, 340);
            positions_min.Name = "positions_min";
            positions_min.Size = new Size(26, 23);
            positions_min.TabIndex = 3;
            positions_min.Text = "1";
            positions_min.TextChanged += positions_min_TextChanged;
            positions_min.KeyPress += positions_min_KeyPress;
            // 
            // accented_latters_box
            // 
            accented_latters_box.CheckOnClick = true;
            accented_latters_box.ColumnWidth = 60;
            accented_latters_box.Font = new Font("Segoe UI", 12F);
            accented_latters_box.FormattingEnabled = true;
            accented_latters_box.HorizontalScrollbar = true;
            accented_latters_box.Items.AddRange(new object[] { "Á", "á", "É", "é", "Í", "í", "Ó", "ó", "Ú", "ú", "À", "à", "È", "è", "Ì", "ì", "Ò", "ò", "Ù", "ù", "Â", "â", "Ê", "ê", "Î", "î", "Ô", "ô", "Û", "û", "Ä", "ä", "Ö", "ö", "Ü", "ü", "ß", "Ç", "ç", "Ñ", "ñ" });
            accented_latters_box.Location = new Point(241, 76);
            accented_latters_box.MultiColumn = true;
            accented_latters_box.Name = "accented_latters_box";
            accented_latters_box.Size = new Size(323, 220);
            accented_latters_box.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 58);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 5;
            label1.Text = "Accented Latters:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 343);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 5;
            label2.Text = "positions number Min:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 343);
            label3.Name = "label3";
            label3.Size = new Size(355, 15);
            label3.TabIndex = 6;
            label3.Text = "how long is the password, example: min 1 and max 4, min <=max";
            // 
            // mathematical_symbols_box
            // 
            mathematical_symbols_box.CheckOnClick = true;
            mathematical_symbols_box.ColumnWidth = 60;
            mathematical_symbols_box.Font = new Font("Segoe UI", 12F);
            mathematical_symbols_box.FormattingEnabled = true;
            mathematical_symbols_box.HorizontalScrollbar = true;
            mathematical_symbols_box.Items.AddRange(new object[] { "+", "-", "*", "/", "^", "~", "=", "%", "<", ">", "≤", "≥", "≠", "∞ ", "√", "∑", "(", ")", "[", "]", "{", "}" });
            mathematical_symbols_box.Location = new Point(703, 76);
            mathematical_symbols_box.MultiColumn = true;
            mathematical_symbols_box.Name = "mathematical_symbols_box";
            mathematical_symbols_box.Size = new Size(186, 220);
            mathematical_symbols_box.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(703, 59);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 5;
            label4.Text = "Mathematical Symbols:";
            // 
            // special_symbols_box
            // 
            special_symbols_box.CheckOnClick = true;
            special_symbols_box.ColumnWidth = 60;
            special_symbols_box.Font = new Font("Segoe UI", 12F);
            special_symbols_box.FormattingEnabled = true;
            special_symbols_box.HorizontalScrollbar = true;
            special_symbols_box.Items.AddRange(new object[] { ".", ",", ";", ":", "!", "?", "'", "\"", "@", "#", "\\", "|", "_" });
            special_symbols_box.Location = new Point(895, 76);
            special_symbols_box.MultiColumn = true;
            special_symbols_box.Name = "special_symbols_box";
            special_symbols_box.Size = new Size(124, 220);
            special_symbols_box.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(895, 58);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 5;
            label5.Text = "Special Symbols:";
            // 
            // currency_symbols_box
            // 
            currency_symbols_box.CheckOnClick = true;
            currency_symbols_box.ColumnWidth = 60;
            currency_symbols_box.Font = new Font("Segoe UI", 12F);
            currency_symbols_box.FormattingEnabled = true;
            currency_symbols_box.HorizontalScrollbar = true;
            currency_symbols_box.Items.AddRange(new object[] { "$", "€", "£", "¥", "₩", "₹", "₽" });
            currency_symbols_box.Location = new Point(1025, 76);
            currency_symbols_box.MultiColumn = true;
            currency_symbols_box.Name = "currency_symbols_box";
            currency_symbols_box.Size = new Size(54, 220);
            currency_symbols_box.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1025, 58);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 5;
            label6.Text = "Currency Symbols:";
            // 
            // greek_letters_box
            // 
            greek_letters_box.CheckOnClick = true;
            greek_letters_box.ColumnWidth = 60;
            greek_letters_box.Font = new Font("Segoe UI", 12F);
            greek_letters_box.FormattingEnabled = true;
            greek_letters_box.HorizontalScrollbar = true;
            greek_letters_box.Items.AddRange(new object[] { "α", "β", "γ", "δ", "ε", "θ", "λ", "μ", "π", "σ", "τ", "φ", "ψ", "ω" });
            greek_letters_box.Location = new Point(570, 76);
            greek_letters_box.MultiColumn = true;
            greek_letters_box.Name = "greek_letters_box";
            greek_letters_box.Size = new Size(127, 220);
            greek_letters_box.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(570, 58);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 5;
            label7.Text = "Greek Letters:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(239, 314);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 5;
            label8.Text = "Exceptions";
            // 
            // exceptions
            // 
            exceptions.Location = new Point(309, 311);
            exceptions.Name = "exceptions";
            exceptions.Size = new Size(161, 23);
            exceptions.TabIndex = 3;
            exceptions.Tag = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(476, 314);
            label9.Name = "label9";
            label9.Size = new Size(312, 15);
            label9.TabIndex = 5;
            label9.Text = "specific characters or numbers you do not wish to include";
            // 
            // white_space
            // 
            white_space.AutoSize = true;
            white_space.Location = new Point(92, 133);
            white_space.Name = "white_space";
            white_space.Size = new Size(91, 19);
            white_space.TabIndex = 2;
            white_space.Text = "White Space";
            white_space.UseVisualStyleBackColor = true;
            // 
            // run
            // 
            run.Location = new Point(804, 433);
            run.Name = "run";
            run.Size = new Size(132, 46);
            run.TabIndex = 7;
            run.Text = "RUN";
            run.UseVisualStyleBackColor = true;
            run.Click += Run_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(239, 372);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 5;
            label10.Text = "Enter File Path";
            // 
            // archive_path
            // 
            archive_path.Location = new Point(327, 369);
            archive_path.Name = "archive_path";
            archive_path.PlaceholderText = "C:\\...";
            archive_path.Size = new Size(461, 23);
            archive_path.TabIndex = 3;
            // 
            // zip
            // 
            zip.AutoSize = true;
            zip.Checked = true;
            zip.Location = new Point(3, 18);
            zip.Name = "zip";
            zip.Size = new Size(42, 19);
            zip.TabIndex = 8;
            zip.TabStop = true;
            zip.Text = "ZIP";
            zip.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(xz);
            panel1.Controls.Add(lzip);
            panel1.Controls.Add(tar);
            panel1.Controls.Add(gzip);
            panel1.Controls.Add(bzip2);
            panel1.Controls.Add(unzip);
            panel1.Controls.Add(unrar);
            panel1.Controls.Add(sz);
            panel1.Controls.Add(szip);
            panel1.Controls.Add(rar);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(zip);
            panel1.Location = new Point(92, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(115, 292);
            panel1.TabIndex = 9;
            // 
            // xz
            // 
            xz.AutoSize = true;
            xz.Location = new Point(3, 268);
            xz.Name = "xz";
            xz.Size = new Size(39, 19);
            xz.TabIndex = 19;
            xz.TabStop = true;
            xz.Text = "XZ";
            xz.UseVisualStyleBackColor = true;
            // 
            // lzip
            // 
            lzip.AutoSize = true;
            lzip.Location = new Point(3, 243);
            lzip.Name = "lzip";
            lzip.Size = new Size(48, 19);
            lzip.TabIndex = 18;
            lzip.TabStop = true;
            lzip.Text = "LZIP";
            lzip.UseVisualStyleBackColor = true;
            // 
            // tar
            // 
            tar.AutoSize = true;
            tar.Location = new Point(3, 218);
            tar.Name = "tar";
            tar.Size = new Size(45, 19);
            tar.TabIndex = 17;
            tar.TabStop = true;
            tar.Text = "TAR";
            tar.UseVisualStyleBackColor = true;
            // 
            // gzip
            // 
            gzip.AutoSize = true;
            gzip.Location = new Point(3, 193);
            gzip.Name = "gzip";
            gzip.Size = new Size(50, 19);
            gzip.TabIndex = 16;
            gzip.TabStop = true;
            gzip.Text = "GZIP";
            gzip.UseVisualStyleBackColor = true;
            // 
            // bzip2
            // 
            bzip2.AutoSize = true;
            bzip2.Location = new Point(3, 168);
            bzip2.Name = "bzip2";
            bzip2.Size = new Size(55, 19);
            bzip2.TabIndex = 15;
            bzip2.TabStop = true;
            bzip2.Text = "BZIP2";
            bzip2.UseVisualStyleBackColor = true;
            // 
            // unzip
            // 
            unzip.AutoSize = true;
            unzip.Location = new Point(3, 143);
            unzip.Name = "unzip";
            unzip.Size = new Size(59, 19);
            unzip.TabIndex = 14;
            unzip.TabStop = true;
            unzip.Text = "UNZIP";
            unzip.UseVisualStyleBackColor = true;
            // 
            // unrar
            // 
            unrar.AutoSize = true;
            unrar.Location = new Point(3, 118);
            unrar.Name = "unrar";
            unrar.Size = new Size(64, 19);
            unrar.TabIndex = 13;
            unrar.TabStop = true;
            unrar.Text = "UNRAR";
            unrar.UseVisualStyleBackColor = true;
            // 
            // sz
            // 
            sz.AutoSize = true;
            sz.Location = new Point(3, 93);
            sz.Name = "sz";
            sz.Size = new Size(36, 19);
            sz.TabIndex = 12;
            sz.TabStop = true;
            sz.Text = "7z";
            sz.UseVisualStyleBackColor = true;
            // 
            // szip
            // 
            szip.AutoSize = true;
            szip.Location = new Point(3, 68);
            szip.Name = "szip";
            szip.Size = new Size(48, 19);
            szip.TabIndex = 11;
            szip.Text = "7ZIP";
            szip.UseVisualStyleBackColor = true;
            // 
            // rar
            // 
            rar.AutoSize = true;
            rar.Location = new Point(3, 43);
            rar.Name = "rar";
            rar.Size = new Size(47, 19);
            rar.TabIndex = 10;
            rar.Text = "RAR";
            rar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 9;
            label11.Text = "Data Type";
            // 
            // numerals
            // 
            numerals.AutoSize = true;
            numerals.Checked = true;
            numerals.CheckState = CheckState.Checked;
            numerals.Location = new Point(92, 108);
            numerals.Name = "numerals";
            numerals.Size = new Size(77, 19);
            numerals.TabIndex = 2;
            numerals.Text = "Numerals";
            numerals.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(239, 406);
            label12.Name = "label12";
            label12.Size = new Size(102, 15);
            label12.TabIndex = 5;
            label12.Text = "Correct Password:";
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(347, 406);
            pass.Name = "pass";
            pass.Size = new Size(0, 15);
            pass.TabIndex = 5;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(398, 433);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(390, 46);
            progressBar1.TabIndex = 10;
            // 
            // positions_max
            // 
            positions_max.Location = new Point(442, 340);
            positions_max.Name = "positions_max";
            positions_max.Size = new Size(26, 23);
            positions_max.TabIndex = 3;
            positions_max.Text = "1";
            positions_max.TextChanged += positions_max_TextChanged;
            positions_max.KeyPress += positions_max_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(406, 343);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 5;
            label13.Text = "Max";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 491);
            Controls.Add(progressBar1);
            Controls.Add(panel1);
            Controls.Add(run);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pass);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(currency_symbols_box);
            Controls.Add(special_symbols_box);
            Controls.Add(mathematical_symbols_box);
            Controls.Add(greek_letters_box);
            Controls.Add(accented_latters_box);
            Controls.Add(exceptions);
            Controls.Add(archive_path);
            Controls.Add(positions_max);
            Controls.Add(positions_min);
            Controls.Add(numerals);
            Controls.Add(white_space);
            Controls.Add(alphabetic_k);
            Controls.Add(alphabetic_s);
            Controls.Add(generate);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generate;
        private CheckBox alphabetic_s;
        private CheckBox alphabetic_k;
        private TextBox positions_min;
        private CheckedListBox accented_latters_box;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckedListBox mathematical_symbols_box;
        private Label label4;
        private CheckedListBox special_symbols_box;
        private Label label5;
        private CheckedListBox currency_symbols_box;
        private Label label6;
        private CheckedListBox greek_letters_box;
        private Label label7;
        private Label label8;
        private TextBox exceptions;
        private Label label9;
        private CheckBox white_space;
        private Button run;
        private Label label10;
        private TextBox archive_path;
        private RadioButton zip;
        private Panel panel1;
        private RadioButton szip;
        private RadioButton rar;
        private Label label11;
        private RadioButton bzip2;
        private RadioButton unzip;
        private RadioButton unrar;
        private RadioButton sz;
        private RadioButton gzip;
        private RadioButton tar;
        private RadioButton xz;
        private RadioButton lzip;
        private CheckBox numerals;
        private Label label12;
        private Label pass;
        private ProgressBar progressBar1;
        private TextBox positions_max;
        private Label label13;
    }
}
