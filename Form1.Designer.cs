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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            exceptions_textbox = new TextBox();
            label9 = new Label();
            white_space = new CheckBox();
            run = new Button();
            label10 = new Label();
            archive_path_textbox = new TextBox();
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
            progressBar1 = new ProgressBar();
            positions_max = new TextBox();
            label13 = new Label();
            stop = new Button();
            gen_file_textbox = new TextBox();
            label14 = new Label();
            listTextBox = new RichTextBox();
            generating_textBox = new TextBox();
            pass_textBox = new TextBox();
            progress_textBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // generate
            // 
            generate.BackColor = Color.Goldenrod;
            generate.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            generate.Location = new Point(241, 468);
            generate.Name = "generate";
            generate.Size = new Size(134, 46);
            generate.TabIndex = 0;
            generate.Text = "Generate";
            generate.UseVisualStyleBackColor = false;
            generate.Click += Generate_Click;
            // 
            // alphabetic_s
            // 
            alphabetic_s.Appearance = Appearance.Button;
            alphabetic_s.AutoSize = true;
            alphabetic_s.BackColor = Color.SandyBrown;
            alphabetic_s.Checked = true;
            alphabetic_s.CheckState = CheckState.Checked;
            alphabetic_s.FlatAppearance.BorderColor = Color.Gray;
            alphabetic_s.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            alphabetic_s.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            alphabetic_s.FlatStyle = FlatStyle.Flat;
            alphabetic_s.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alphabetic_s.ForeColor = SystemColors.ActiveCaptionText;
            alphabetic_s.Location = new Point(92, 59);
            alphabetic_s.Name = "alphabetic_s";
            alphabetic_s.Size = new Size(109, 25);
            alphabetic_s.TabIndex = 1;
            alphabetic_s.Text = "Alphabetic Small";
            alphabetic_s.UseVisualStyleBackColor = false;
            // 
            // alphabetic_k
            // 
            alphabetic_k.Appearance = Appearance.Button;
            alphabetic_k.AutoSize = true;
            alphabetic_k.BackColor = Color.SandyBrown;
            alphabetic_k.Checked = true;
            alphabetic_k.CheckState = CheckState.Checked;
            alphabetic_k.FlatAppearance.BorderColor = Color.Gray;
            alphabetic_k.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            alphabetic_k.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            alphabetic_k.FlatStyle = FlatStyle.Flat;
            alphabetic_k.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            alphabetic_k.Location = new Point(92, 90);
            alphabetic_k.Name = "alphabetic_k";
            alphabetic_k.Size = new Size(117, 25);
            alphabetic_k.TabIndex = 2;
            alphabetic_k.Text = "Alphabetic Kapital";
            alphabetic_k.UseVisualStyleBackColor = false;
            // 
            // positions_min
            // 
            positions_min.BackColor = Color.Linen;
            positions_min.BorderStyle = BorderStyle.FixedSingle;
            positions_min.Location = new Point(379, 340);
            positions_min.Name = "positions_min";
            positions_min.Size = new Size(26, 23);
            positions_min.TabIndex = 3;
            positions_min.Text = "1";
            positions_min.TextChanged += Positions_min_TextChanged;
            positions_min.KeyPress += Positions_min_KeyPress;
            // 
            // accented_latters_box
            // 
            accented_latters_box.BackColor = Color.Linen;
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
            label1.BackColor = Color.SandyBrown;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(241, 58);
            label1.Name = "label1";
            label1.Size = new Size(107, 17);
            label1.TabIndex = 5;
            label1.Text = "Accented Latters:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(239, 343);
            label2.Name = "label2";
            label2.Size = new Size(132, 17);
            label2.TabIndex = 5;
            label2.Text = "positions number Min:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SandyBrown;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(482, 343);
            label3.Name = "label3";
            label3.Size = new Size(369, 17);
            label3.TabIndex = 6;
            label3.Text = "how long is the password, example: min 1 and max 4, min <=max";
            // 
            // mathematical_symbols_box
            // 
            mathematical_symbols_box.BackColor = Color.Linen;
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
            label4.BackColor = Color.SandyBrown;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(703, 59);
            label4.Name = "label4";
            label4.Size = new Size(137, 17);
            label4.TabIndex = 5;
            label4.Text = "Mathematical Symbols:";
            // 
            // special_symbols_box
            // 
            special_symbols_box.BackColor = Color.Linen;
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
            label5.BackColor = Color.SandyBrown;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(895, 58);
            label5.Name = "label5";
            label5.Size = new Size(100, 17);
            label5.TabIndex = 5;
            label5.Text = "Special Symbols:";
            // 
            // currency_symbols_box
            // 
            currency_symbols_box.BackColor = Color.Linen;
            currency_symbols_box.CheckOnClick = true;
            currency_symbols_box.ColumnWidth = 60;
            currency_symbols_box.Font = new Font("Segoe UI", 12F);
            currency_symbols_box.FormattingEnabled = true;
            currency_symbols_box.HorizontalScrollbar = true;
            currency_symbols_box.Items.AddRange(new object[] { "$", "€", "£", "¥", "₩", "₹", "₽" });
            currency_symbols_box.Location = new Point(1025, 76);
            currency_symbols_box.MultiColumn = true;
            currency_symbols_box.Name = "currency_symbols_box";
            currency_symbols_box.Size = new Size(106, 220);
            currency_symbols_box.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.SandyBrown;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(1025, 58);
            label6.Name = "label6";
            label6.Size = new Size(111, 17);
            label6.TabIndex = 5;
            label6.Text = "Currency Symbols:";
            // 
            // greek_letters_box
            // 
            greek_letters_box.BackColor = Color.Linen;
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
            label7.BackColor = Color.SandyBrown;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(570, 58);
            label7.Name = "label7";
            label7.Size = new Size(90, 17);
            label7.TabIndex = 5;
            label7.Text = "Greek Letters:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.SandyBrown;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(239, 314);
            label8.Name = "label8";
            label8.Size = new Size(69, 17);
            label8.TabIndex = 5;
            label8.Text = "Exceptions";
            // 
            // exceptions_textbox
            // 
            exceptions_textbox.BackColor = Color.Linen;
            exceptions_textbox.BorderStyle = BorderStyle.FixedSingle;
            exceptions_textbox.Location = new Point(314, 312);
            exceptions_textbox.Name = "exceptions_textbox";
            exceptions_textbox.Size = new Size(161, 23);
            exceptions_textbox.TabIndex = 3;
            exceptions_textbox.Tag = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.SandyBrown;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(481, 314);
            label9.Name = "label9";
            label9.Size = new Size(327, 17);
            label9.TabIndex = 5;
            label9.Text = "specific characters or numbers you do not wish to include";
            // 
            // white_space
            // 
            white_space.Appearance = Appearance.Button;
            white_space.AutoSize = true;
            white_space.BackColor = Color.SandyBrown;
            white_space.FlatAppearance.BorderColor = Color.Gray;
            white_space.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            white_space.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            white_space.FlatStyle = FlatStyle.Flat;
            white_space.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            white_space.Location = new Point(92, 152);
            white_space.Name = "white_space";
            white_space.Size = new Size(87, 25);
            white_space.TabIndex = 2;
            white_space.Text = "White Space";
            white_space.UseVisualStyleBackColor = false;
            // 
            // run
            // 
            run.BackColor = Color.YellowGreen;
            run.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            run.Location = new Point(861, 468);
            run.Name = "run";
            run.Size = new Size(132, 46);
            run.TabIndex = 7;
            run.Text = "RUN";
            run.UseVisualStyleBackColor = false;
            run.Click += Run_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.SandyBrown;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(239, 372);
            label10.Name = "label10";
            label10.Size = new Size(113, 17);
            label10.TabIndex = 5;
            label10.Text = "Enter Archive Path";
            // 
            // archive_path_textbox
            // 
            archive_path_textbox.BackColor = Color.Linen;
            archive_path_textbox.BorderStyle = BorderStyle.FixedSingle;
            archive_path_textbox.Location = new Point(358, 370);
            archive_path_textbox.Name = "archive_path_textbox";
            archive_path_textbox.PlaceholderText = "C:\\...";
            archive_path_textbox.Size = new Size(461, 23);
            archive_path_textbox.TabIndex = 3;
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
            panel1.BackColor = Color.Linen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            panel1.Location = new Point(92, 183);
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
            numerals.Appearance = Appearance.Button;
            numerals.AutoSize = true;
            numerals.BackColor = Color.SandyBrown;
            numerals.Checked = true;
            numerals.CheckState = CheckState.Checked;
            numerals.FlatAppearance.BorderColor = Color.Gray;
            numerals.FlatAppearance.CheckedBackColor = Color.LightSkyBlue;
            numerals.FlatAppearance.MouseDownBackColor = SystemColors.GradientActiveCaption;
            numerals.FlatStyle = FlatStyle.Flat;
            numerals.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numerals.Location = new Point(92, 121);
            numerals.Name = "numerals";
            numerals.Size = new Size(70, 25);
            numerals.TabIndex = 2;
            numerals.Text = "Numerals";
            numerals.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.SandyBrown;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(861, 435);
            label12.Name = "label12";
            label12.Size = new Size(109, 17);
            label12.TabIndex = 5;
            label12.Text = "Correct Password:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(381, 477);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(474, 37);
            progressBar1.TabIndex = 10;
            // 
            // positions_max
            // 
            positions_max.BackColor = Color.Linen;
            positions_max.BorderStyle = BorderStyle.FixedSingle;
            positions_max.Location = new Point(450, 340);
            positions_max.Name = "positions_max";
            positions_max.Size = new Size(26, 23);
            positions_max.TabIndex = 3;
            positions_max.Text = "1";
            positions_max.TextChanged += Positions_max_TextChanged;
            positions_max.KeyPress += Positions_max_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.SandyBrown;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(411, 343);
            label13.Name = "label13";
            label13.Size = new Size(33, 17);
            label13.TabIndex = 5;
            label13.Text = "Max";
            // 
            // stop
            // 
            stop.BackColor = Color.Tomato;
            stop.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            stop.Location = new Point(999, 468);
            stop.Name = "stop";
            stop.Size = new Size(132, 46);
            stop.TabIndex = 11;
            stop.Text = "STOP";
            stop.UseVisualStyleBackColor = false;
            stop.Click += Stop_Click;
            // 
            // gen_file_textbox
            // 
            gen_file_textbox.BackColor = Color.Linen;
            gen_file_textbox.BorderStyle = BorderStyle.FixedSingle;
            gen_file_textbox.Location = new Point(395, 399);
            gen_file_textbox.Name = "gen_file_textbox";
            gen_file_textbox.PlaceholderText = "C:\\...";
            gen_file_textbox.Size = new Size(427, 23);
            gen_file_textbox.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.SandyBrown;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(239, 401);
            label14.Name = "label14";
            label14.Size = new Size(150, 17);
            label14.TabIndex = 5;
            label14.Text = "Enter genetated File Path";
            // 
            // listTextBox
            // 
            listTextBox.BackColor = Color.Linen;
            listTextBox.Location = new Point(895, 302);
            listTextBox.Name = "listTextBox";
            listTextBox.Size = new Size(236, 116);
            listTextBox.TabIndex = 12;
            listTextBox.Text = "";
            // 
            // generating_textBox
            // 
            generating_textBox.BackColor = Color.Linen;
            generating_textBox.BorderStyle = BorderStyle.FixedSingle;
            generating_textBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generating_textBox.Location = new Point(241, 448);
            generating_textBox.Name = "generating_textBox";
            generating_textBox.ReadOnly = true;
            generating_textBox.Size = new Size(134, 23);
            generating_textBox.TabIndex = 13;
            // 
            // pass_textBox
            // 
            pass_textBox.BackColor = Color.Linen;
            pass_textBox.BorderStyle = BorderStyle.FixedSingle;
            pass_textBox.Location = new Point(976, 433);
            pass_textBox.Name = "pass_textBox";
            pass_textBox.ReadOnly = true;
            pass_textBox.Size = new Size(155, 23);
            pass_textBox.TabIndex = 14;
            // 
            // progress_textBox
            // 
            progress_textBox.BackColor = Color.Linen;
            progress_textBox.BorderStyle = BorderStyle.FixedSingle;
            progress_textBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            progress_textBox.Location = new Point(381, 448);
            progress_textBox.Name = "progress_textBox";
            progress_textBox.ReadOnly = true;
            progress_textBox.Size = new Size(111, 23);
            progress_textBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1151, 540);
            Controls.Add(pass_textBox);
            Controls.Add(progress_textBox);
            Controls.Add(generating_textBox);
            Controls.Add(listTextBox);
            Controls.Add(stop);
            Controls.Add(progressBar1);
            Controls.Add(panel1);
            Controls.Add(run);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label12);
            Controls.Add(label14);
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
            Controls.Add(exceptions_textbox);
            Controls.Add(gen_file_textbox);
            Controls.Add(archive_path_textbox);
            Controls.Add(positions_max);
            Controls.Add(positions_min);
            Controls.Add(numerals);
            Controls.Add(white_space);
            Controls.Add(alphabetic_k);
            Controls.Add(alphabetic_s);
            Controls.Add(generate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "PassFinder";
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
        private TextBox exceptions_textbox;
        private Label label9;
        private CheckBox white_space;
        private Button run;
        private Label label10;
        private TextBox archive_path_textbox;
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
        private ProgressBar progressBar1;
        private TextBox positions_max;
        private Label label13;
        private Button stop;
        private TextBox gen_file_textbox;
        private Label label14;
        private RichTextBox listTextBox;
        private TextBox generating_textBox;
        private TextBox pass_textBox;
        private TextBox progress_textBox;
    }
}
