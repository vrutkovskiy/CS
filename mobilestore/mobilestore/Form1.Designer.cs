namespace mobilestore
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhonesBox = new System.Windows.Forms.ListBox();
            this.Readfile = new System.Windows.Forms.Button();
            this.Savetofile = new System.Windows.Forms.Button();
            this.delall = new System.Windows.Forms.Button();
            this.delselect = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Pricetb = new System.Windows.Forms.TextBox();
            this.Procesrtb = new System.Windows.Forms.TextBox();
            this.Ostb = new System.Windows.Forms.TextBox();
            this.Modeltb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PhoneoptoinsBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Optionsmenu = new System.Windows.Forms.GroupBox();
            this.optname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.savechangebtn = new System.Windows.Forms.Button();
            this.delopt = new System.Windows.Forms.Button();
            this.Optionbox = new System.Windows.Forms.CheckedListBox();
            this.Addopt = new System.Windows.Forms.Button();
            this.Fillbox = new System.Windows.Forms.GroupBox();
            this.Editpicpathtb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Editpricetb = new System.Windows.Forms.TextBox();
            this.Editprocsrtb = new System.Windows.Forms.TextBox();
            this.Editostb = new System.Windows.Forms.TextBox();
            this.Editmodeltb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Addphonebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Optionsmenu.SuspendLayout();
            this.Fillbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PhonesBox);
            this.groupBox1.Controls.Add(this.Readfile);
            this.groupBox1.Controls.Add(this.Savetofile);
            this.groupBox1.Controls.Add(this.delall);
            this.groupBox1.Controls.Add(this.delselect);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 546);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список телефонов магазина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "_________________________________________________________";
            // 
            // PhonesBox
            // 
            this.PhonesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhonesBox.FormattingEnabled = true;
            this.PhonesBox.ItemHeight = 16;
            this.PhonesBox.Location = new System.Drawing.Point(14, 24);
            this.PhonesBox.Name = "PhonesBox";
            this.PhonesBox.Size = new System.Drawing.Size(360, 340);
            this.PhonesBox.TabIndex = 4;
            this.PhonesBox.SelectedIndexChanged += new System.EventHandler(this.PhonesBox_SelectedIndexChanged);
            // 
            // Readfile
            // 
            this.Readfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Readfile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Readfile.Location = new System.Drawing.Point(213, 461);
            this.Readfile.Name = "Readfile";
            this.Readfile.Size = new System.Drawing.Size(150, 50);
            this.Readfile.TabIndex = 3;
            this.Readfile.Text = "Прочитать из файла";
            this.Readfile.UseVisualStyleBackColor = true;
            this.Readfile.Click += new System.EventHandler(this.Readfile_Click);
            // 
            // Savetofile
            // 
            this.Savetofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Savetofile.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Savetofile.Location = new System.Drawing.Point(28, 461);
            this.Savetofile.Name = "Savetofile";
            this.Savetofile.Size = new System.Drawing.Size(150, 50);
            this.Savetofile.TabIndex = 2;
            this.Savetofile.Text = "Сохранить в файл";
            this.Savetofile.UseVisualStyleBackColor = true;
            this.Savetofile.Click += new System.EventHandler(this.Savetofile_Click);
            // 
            // delall
            // 
            this.delall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delall.Location = new System.Drawing.Point(213, 380);
            this.delall.Name = "delall";
            this.delall.Size = new System.Drawing.Size(150, 50);
            this.delall.TabIndex = 1;
            this.delall.Text = "Очистить список";
            this.delall.UseVisualStyleBackColor = true;
            this.delall.Click += new System.EventHandler(this.delall_Click);
            // 
            // delselect
            // 
            this.delselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delselect.Location = new System.Drawing.Point(28, 380);
            this.delselect.Name = "delselect";
            this.delselect.Size = new System.Drawing.Size(150, 50);
            this.delselect.TabIndex = 0;
            this.delselect.Text = "Удалить текущую";
            this.delselect.UseVisualStyleBackColor = true;
            this.delselect.Click += new System.EventHandler(this.delselect_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Location = new System.Drawing.Point(415, 23);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(449, 535);
            this.Tabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Pricetb);
            this.tabPage1.Controls.Add(this.Procesrtb);
            this.tabPage1.Controls.Add(this.Ostb);
            this.tabPage1.Controls.Add(this.Modeltb);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация о телефоне";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Pricetb
            // 
            this.Pricetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pricetb.Location = new System.Drawing.Point(196, 298);
            this.Pricetb.Name = "Pricetb";
            this.Pricetb.ReadOnly = true;
            this.Pricetb.Size = new System.Drawing.Size(223, 23);
            this.Pricetb.TabIndex = 9;
            this.Pricetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Procesrtb
            // 
            this.Procesrtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Procesrtb.Location = new System.Drawing.Point(196, 270);
            this.Procesrtb.Name = "Procesrtb";
            this.Procesrtb.ReadOnly = true;
            this.Procesrtb.Size = new System.Drawing.Size(223, 23);
            this.Procesrtb.TabIndex = 8;
            this.Procesrtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Ostb
            // 
            this.Ostb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ostb.Location = new System.Drawing.Point(196, 243);
            this.Ostb.Name = "Ostb";
            this.Ostb.ReadOnly = true;
            this.Ostb.Size = new System.Drawing.Size(223, 23);
            this.Ostb.TabIndex = 7;
            this.Ostb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Modeltb
            // 
            this.Modeltb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Modeltb.Location = new System.Drawing.Point(196, 215);
            this.Modeltb.Name = "Modeltb";
            this.Modeltb.ReadOnly = true;
            this.Modeltb.Size = new System.Drawing.Size(223, 23);
            this.Modeltb.TabIndex = 6;
            this.Modeltb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PhoneoptoinsBox);
            this.groupBox2.Location = new System.Drawing.Point(17, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 179);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ОПЦИИ:";
            // 
            // PhoneoptoinsBox
            // 
            this.PhoneoptoinsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneoptoinsBox.FormattingEnabled = true;
            this.PhoneoptoinsBox.ItemHeight = 16;
            this.PhoneoptoinsBox.Location = new System.Drawing.Point(6, 19);
            this.PhoneoptoinsBox.Name = "PhoneoptoinsBox";
            this.PhoneoptoinsBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.PhoneoptoinsBox.Size = new System.Drawing.Size(396, 132);
            this.PhoneoptoinsBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(24, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(24, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Процессор:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(24, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "OS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(24, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модель:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(23, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Optionsmenu);
            this.tabPage2.Controls.Add(this.Fillbox);
            this.tabPage2.Controls.Add(this.Addphonebtn);
            this.tabPage2.Controls.Add(this.Clearbtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактирование информации";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Optionsmenu
            // 
            this.Optionsmenu.Controls.Add(this.optname);
            this.Optionsmenu.Controls.Add(this.label11);
            this.Optionsmenu.Controls.Add(this.savechangebtn);
            this.Optionsmenu.Controls.Add(this.delopt);
            this.Optionsmenu.Controls.Add(this.Optionbox);
            this.Optionsmenu.Controls.Add(this.Addopt);
            this.Optionsmenu.Location = new System.Drawing.Point(12, 180);
            this.Optionsmenu.Name = "Optionsmenu";
            this.Optionsmenu.Size = new System.Drawing.Size(417, 266);
            this.Optionsmenu.TabIndex = 29;
            this.Optionsmenu.TabStop = false;
            // 
            // optname
            // 
            this.optname.Location = new System.Drawing.Point(180, 186);
            this.optname.Name = "optname";
            this.optname.Size = new System.Drawing.Size(223, 20);
            this.optname.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(8, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Название опции";
            // 
            // savechangebtn
            // 
            this.savechangebtn.Location = new System.Drawing.Point(11, 146);
            this.savechangebtn.Name = "savechangebtn";
            this.savechangebtn.Size = new System.Drawing.Size(392, 29);
            this.savechangebtn.TabIndex = 21;
            this.savechangebtn.Text = "Сохранить изменения";
            this.savechangebtn.UseVisualStyleBackColor = true;
            this.savechangebtn.Click += new System.EventHandler(this.savechangebtn_Click);
            // 
            // delopt
            // 
            this.delopt.Location = new System.Drawing.Point(226, 220);
            this.delopt.Name = "delopt";
            this.delopt.Size = new System.Drawing.Size(180, 33);
            this.delopt.TabIndex = 24;
            this.delopt.Text = "Удалить отмеченные опции";
            this.delopt.UseVisualStyleBackColor = true;
            this.delopt.Click += new System.EventHandler(this.delopt_Click);
            // 
            // Optionbox
            // 
            this.Optionbox.CheckOnClick = true;
            this.Optionbox.FormattingEnabled = true;
            this.Optionbox.Location = new System.Drawing.Point(11, 22);
            this.Optionbox.Name = "Optionbox";
            this.Optionbox.Size = new System.Drawing.Size(392, 109);
            this.Optionbox.TabIndex = 20;
            // 
            // Addopt
            // 
            this.Addopt.Location = new System.Drawing.Point(14, 220);
            this.Addopt.Name = "Addopt";
            this.Addopt.Size = new System.Drawing.Size(180, 33);
            this.Addopt.TabIndex = 22;
            this.Addopt.Text = "Добавить опцию";
            this.Addopt.UseVisualStyleBackColor = true;
            this.Addopt.Click += new System.EventHandler(this.Addopt_Click);
            // 
            // Fillbox
            // 
            this.Fillbox.Controls.Add(this.Editpicpathtb);
            this.Fillbox.Controls.Add(this.label10);
            this.Fillbox.Controls.Add(this.Editpricetb);
            this.Fillbox.Controls.Add(this.Editprocsrtb);
            this.Fillbox.Controls.Add(this.Editostb);
            this.Fillbox.Controls.Add(this.Editmodeltb);
            this.Fillbox.Controls.Add(this.label6);
            this.Fillbox.Controls.Add(this.label7);
            this.Fillbox.Controls.Add(this.label8);
            this.Fillbox.Controls.Add(this.label9);
            this.Fillbox.Location = new System.Drawing.Point(12, 6);
            this.Fillbox.Name = "Fillbox";
            this.Fillbox.Size = new System.Drawing.Size(418, 168);
            this.Fillbox.TabIndex = 28;
            this.Fillbox.TabStop = false;
            // 
            // Editpicpathtb
            // 
            this.Editpicpathtb.Location = new System.Drawing.Point(183, 105);
            this.Editpicpathtb.Name = "Editpicpathtb";
            this.Editpicpathtb.Size = new System.Drawing.Size(223, 20);
            this.Editpicpathtb.TabIndex = 19;
            this.Editpicpathtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(11, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Путь к картинке:";
            // 
            // Editpricetb
            // 
            this.Editpricetb.Location = new System.Drawing.Point(183, 132);
            this.Editpricetb.Name = "Editpricetb";
            this.Editpricetb.Size = new System.Drawing.Size(223, 20);
            this.Editpricetb.TabIndex = 17;
            this.Editpricetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Editprocsrtb
            // 
            this.Editprocsrtb.Location = new System.Drawing.Point(183, 76);
            this.Editprocsrtb.Name = "Editprocsrtb";
            this.Editprocsrtb.Size = new System.Drawing.Size(223, 20);
            this.Editprocsrtb.TabIndex = 16;
            this.Editprocsrtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Editostb
            // 
            this.Editostb.Location = new System.Drawing.Point(183, 49);
            this.Editostb.Name = "Editostb";
            this.Editostb.Size = new System.Drawing.Size(223, 20);
            this.Editostb.TabIndex = 15;
            this.Editostb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Editmodeltb
            // 
            this.Editmodeltb.Location = new System.Drawing.Point(183, 21);
            this.Editmodeltb.Name = "Editmodeltb";
            this.Editmodeltb.Size = new System.Drawing.Size(223, 20);
            this.Editmodeltb.TabIndex = 14;
            this.Editmodeltb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(11, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Цена:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(11, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Процессор:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(11, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "OS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Модель:";
            // 
            // Addphonebtn
            // 
            this.Addphonebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addphonebtn.ForeColor = System.Drawing.Color.Red;
            this.Addphonebtn.Location = new System.Drawing.Point(240, 452);
            this.Addphonebtn.Name = "Addphonebtn";
            this.Addphonebtn.Size = new System.Drawing.Size(178, 46);
            this.Addphonebtn.TabIndex = 25;
            this.Addphonebtn.Text = "Добавить новый телефон";
            this.Addphonebtn.UseVisualStyleBackColor = true;
            this.Addphonebtn.Click += new System.EventHandler(this.Addphonebtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearbtn.ForeColor = System.Drawing.Color.Red;
            this.Clearbtn.Location = new System.Drawing.Point(26, 452);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(180, 46);
            this.Clearbtn.TabIndex = 23;
            this.Clearbtn.Text = "Очистить поля";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 570);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mobile store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.Optionsmenu.ResumeLayout(false);
            this.Optionsmenu.PerformLayout();
            this.Fillbox.ResumeLayout(false);
            this.Fillbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PhonesBox;
        private System.Windows.Forms.Button Readfile;
        private System.Windows.Forms.Button Savetofile;
        private System.Windows.Forms.Button delall;
        private System.Windows.Forms.Button delselect;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Pricetb;
        private System.Windows.Forms.TextBox Procesrtb;
        private System.Windows.Forms.TextBox Ostb;
        private System.Windows.Forms.TextBox Modeltb;
        private System.Windows.Forms.ListBox PhoneoptoinsBox;
        private System.Windows.Forms.CheckedListBox Optionbox;
        private System.Windows.Forms.TextBox Editpicpathtb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Editpricetb;
        private System.Windows.Forms.TextBox Editprocsrtb;
        private System.Windows.Forms.TextBox Editostb;
        private System.Windows.Forms.TextBox Editmodeltb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox Optionsmenu;
        private System.Windows.Forms.TextBox optname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button savechangebtn;
        private System.Windows.Forms.GroupBox Fillbox;
        private System.Windows.Forms.Button Addphonebtn;
        private System.Windows.Forms.Button delopt;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Addopt;
    }
}

