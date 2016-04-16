namespace zapravka
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Topay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fuelprice = new System.Windows.Forms.TextBox();
            this.Fuel = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Amountsum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Litersqt = new System.Windows.Forms.TextBox();
            this.Amountcheck = new System.Windows.Forms.RadioButton();
            this.Literscheck = new System.Windows.Forms.RadioButton();
            this.Fuelpricelb = new System.Windows.Forms.Label();
            this.Fueltype = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kolaqt = new System.Windows.Forms.TextBox();
            this.kolaprs = new System.Windows.Forms.TextBox();
            this.chizburgqt = new System.Windows.Forms.TextBox();
            this.chizburgprs = new System.Windows.Forms.TextBox();
            this.hamburgqt = new System.Windows.Forms.TextBox();
            this.hamburgprs = new System.Windows.Forms.TextBox();
            this.hotdogqt = new System.Windows.Forms.TextBox();
            this.hotdogprs = new System.Windows.Forms.TextBox();
            this.kola = new System.Windows.Forms.CheckBox();
            this.chizburg = new System.Windows.Forms.CheckBox();
            this.hamburg = new System.Windows.Forms.CheckBox();
            this.hotdog = new System.Windows.Forms.CheckBox();
            this.Kafeqts = new System.Windows.Forms.Label();
            this.Kafeprices = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Kafepay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.rezultsum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Fuelprice);
            this.groupBox1.Controls.Add(this.Fuel);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.Fuelpricelb);
            this.groupBox1.Controls.Add(this.Fueltype);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Топливо";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Topay);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(22, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(274, 84);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "К оплате";
            // 
            // Topay
            // 
            this.Topay.Enabled = false;
            this.Topay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Topay.Location = new System.Drawing.Point(15, 22);
            this.Topay.Name = "Topay";
            this.Topay.Size = new System.Drawing.Size(237, 45);
            this.Topay.TabIndex = 0;
            this.Topay.Tag = "1";
            this.Topay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Topay.TextChanged += new System.EventHandler(this.topay_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(261, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "руб.";
            // 
            // Fuelprice
            // 
            this.Fuelprice.Enabled = false;
            this.Fuelprice.Location = new System.Drawing.Point(107, 59);
            this.Fuelprice.Name = "Fuelprice";
            this.Fuelprice.Size = new System.Drawing.Size(148, 20);
            this.Fuelprice.TabIndex = 4;
            this.Fuelprice.Text = "11100";
            this.Fuelprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Fuelprice.TextChanged += new System.EventHandler(this.Benz_TextChanged);
            // 
            // Fuel
            // 
            this.Fuel.Items.AddRange(new object[] {
            "АИ-92",
            "АИ-95",
            "АИ-98"});
            this.Fuel.Location = new System.Drawing.Point(107, 25);
            this.Fuel.Name = "Fuel";
            this.Fuel.Size = new System.Drawing.Size(148, 21);
            this.Fuel.TabIndex = 3;
            this.Fuel.Text = "АИ-92";
            this.Fuel.TextChanged += new System.EventHandler(this.Benz_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Amountsum);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Litersqt);
            this.groupBox3.Controls.Add(this.Amountcheck);
            this.groupBox3.Controls.Add(this.Literscheck);
            this.groupBox3.Location = new System.Drawing.Point(22, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(239, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "руб.";
            // 
            // Amountsum
            // 
            this.Amountsum.Location = new System.Drawing.Point(117, 55);
            this.Amountsum.Name = "Amountsum";
            this.Amountsum.Size = new System.Drawing.Size(116, 20);
            this.Amountsum.TabIndex = 4;
            this.Amountsum.Tag = "1";
            this.Amountsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Amountsum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Amountsum_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(239, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "л.";
            // 
            // Litersqt
            // 
            this.Litersqt.Location = new System.Drawing.Point(117, 23);
            this.Litersqt.Name = "Litersqt";
            this.Litersqt.Size = new System.Drawing.Size(116, 20);
            this.Litersqt.TabIndex = 2;
            this.Litersqt.Tag = "1";
            this.Litersqt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Litersqt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.litersquantity_KeyUp);
            // 
            // Amountcheck
            // 
            this.Amountcheck.AutoSize = true;
            this.Amountcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amountcheck.Location = new System.Drawing.Point(18, 54);
            this.Amountcheck.Name = "Amountcheck";
            this.Amountcheck.Size = new System.Drawing.Size(64, 17);
            this.Amountcheck.TabIndex = 1;
            this.Amountcheck.TabStop = true;
            this.Amountcheck.Text = "Сумма";
            this.Amountcheck.UseVisualStyleBackColor = true;
            this.Amountcheck.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // Literscheck
            // 
            this.Literscheck.AutoSize = true;
            this.Literscheck.Checked = true;
            this.Literscheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Literscheck.Location = new System.Drawing.Point(18, 23);
            this.Literscheck.Name = "Literscheck";
            this.Literscheck.Size = new System.Drawing.Size(94, 17);
            this.Literscheck.TabIndex = 0;
            this.Literscheck.TabStop = true;
            this.Literscheck.Text = "Количество";
            this.Literscheck.UseVisualStyleBackColor = true;
            this.Literscheck.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // Fuelpricelb
            // 
            this.Fuelpricelb.AutoSize = true;
            this.Fuelpricelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fuelpricelb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Fuelpricelb.Location = new System.Drawing.Point(19, 59);
            this.Fuelpricelb.Name = "Fuelpricelb";
            this.Fuelpricelb.Size = new System.Drawing.Size(47, 17);
            this.Fuelpricelb.TabIndex = 1;
            this.Fuelpricelb.Text = "Цена";
            // 
            // Fueltype
            // 
            this.Fueltype.AutoSize = true;
            this.Fueltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fueltype.Location = new System.Drawing.Point(19, 25);
            this.Fueltype.Name = "Fueltype";
            this.Fueltype.Size = new System.Drawing.Size(62, 17);
            this.Fueltype.TabIndex = 0;
            this.Fueltype.Text = "Бензин";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.kolaqt);
            this.groupBox2.Controls.Add(this.kolaprs);
            this.groupBox2.Controls.Add(this.chizburgqt);
            this.groupBox2.Controls.Add(this.chizburgprs);
            this.groupBox2.Controls.Add(this.hamburgqt);
            this.groupBox2.Controls.Add(this.hamburgprs);
            this.groupBox2.Controls.Add(this.hotdogqt);
            this.groupBox2.Controls.Add(this.hotdogprs);
            this.groupBox2.Controls.Add(this.kola);
            this.groupBox2.Controls.Add(this.chizburg);
            this.groupBox2.Controls.Add(this.hamburg);
            this.groupBox2.Controls.Add(this.hotdog);
            this.groupBox2.Controls.Add(this.Kafeqts);
            this.groupBox2.Controls.Add(this.Kafeprices);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(343, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Супер кафе";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(197, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "руб.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(197, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "руб.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(197, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "руб.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(197, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "руб.";
            // 
            // kolaqt
            // 
            this.kolaqt.Enabled = false;
            this.kolaqt.Location = new System.Drawing.Point(229, 152);
            this.kolaqt.Name = "kolaqt";
            this.kolaqt.Size = new System.Drawing.Size(85, 20);
            this.kolaqt.TabIndex = 14;
            this.kolaqt.Tag = "12";
            this.kolaqt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.kolaqt.Click += new System.EventHandler(this.kola_Click);
            this.kolaqt.TextChanged += new System.EventHandler(this.hotdogqt_TextChanged);
            // 
            // kolaprs
            // 
            this.kolaprs.Enabled = false;
            this.kolaprs.Location = new System.Drawing.Point(117, 152);
            this.kolaprs.Name = "kolaprs";
            this.kolaprs.Size = new System.Drawing.Size(74, 20);
            this.kolaprs.TabIndex = 13;
            this.kolaprs.Text = "15000";
            this.kolaprs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chizburgqt
            // 
            this.chizburgqt.Enabled = false;
            this.chizburgqt.Location = new System.Drawing.Point(230, 122);
            this.chizburgqt.Name = "chizburgqt";
            this.chizburgqt.Size = new System.Drawing.Size(84, 20);
            this.chizburgqt.TabIndex = 12;
            this.chizburgqt.Tag = "12";
            this.chizburgqt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chizburgqt.Click += new System.EventHandler(this.chizburgqt_Click);
            this.chizburgqt.TextChanged += new System.EventHandler(this.hotdogqt_TextChanged);
            // 
            // chizburgprs
            // 
            this.chizburgprs.Enabled = false;
            this.chizburgprs.Location = new System.Drawing.Point(117, 122);
            this.chizburgprs.Name = "chizburgprs";
            this.chizburgprs.Size = new System.Drawing.Size(74, 20);
            this.chizburgprs.TabIndex = 11;
            this.chizburgprs.Text = "35000";
            this.chizburgprs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hamburgqt
            // 
            this.hamburgqt.Enabled = false;
            this.hamburgqt.Location = new System.Drawing.Point(230, 94);
            this.hamburgqt.Name = "hamburgqt";
            this.hamburgqt.Size = new System.Drawing.Size(84, 20);
            this.hamburgqt.TabIndex = 10;
            this.hamburgqt.Tag = "12";
            this.hamburgqt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hamburgqt.Click += new System.EventHandler(this.hamburg_Click);
            this.hamburgqt.TextChanged += new System.EventHandler(this.hotdogqt_TextChanged);
            // 
            // hamburgprs
            // 
            this.hamburgprs.Enabled = false;
            this.hamburgprs.Location = new System.Drawing.Point(117, 94);
            this.hamburgprs.Name = "hamburgprs";
            this.hamburgprs.Size = new System.Drawing.Size(74, 20);
            this.hamburgprs.TabIndex = 9;
            this.hamburgprs.Text = "32500";
            this.hamburgprs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hotdogqt
            // 
            this.hotdogqt.Enabled = false;
            this.hotdogqt.Location = new System.Drawing.Point(230, 67);
            this.hotdogqt.Name = "hotdogqt";
            this.hotdogqt.Size = new System.Drawing.Size(84, 20);
            this.hotdogqt.TabIndex = 8;
            this.hotdogqt.Tag = "12";
            this.hotdogqt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hotdogqt.Click += new System.EventHandler(this.checkBox1_Click);
            this.hotdogqt.TextChanged += new System.EventHandler(this.hotdogqt_TextChanged);
            // 
            // hotdogprs
            // 
            this.hotdogprs.Enabled = false;
            this.hotdogprs.Location = new System.Drawing.Point(117, 67);
            this.hotdogprs.Name = "hotdogprs";
            this.hotdogprs.Size = new System.Drawing.Size(74, 20);
            this.hotdogprs.TabIndex = 7;
            this.hotdogprs.Text = "25000";
            this.hotdogprs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // kola
            // 
            this.kola.AutoSize = true;
            this.kola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kola.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.kola.Location = new System.Drawing.Point(24, 150);
            this.kola.Name = "kola";
            this.kola.Size = new System.Drawing.Size(87, 17);
            this.kola.TabIndex = 6;
            this.kola.Text = "Кока-кола";
            this.kola.UseVisualStyleBackColor = true;
            this.kola.Click += new System.EventHandler(this.kola_Click);
            // 
            // chizburg
            // 
            this.chizburg.AutoSize = true;
            this.chizburg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chizburg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.chizburg.Location = new System.Drawing.Point(24, 122);
            this.chizburg.Name = "chizburg";
            this.chizburg.Size = new System.Drawing.Size(89, 17);
            this.chizburg.TabIndex = 5;
            this.chizburg.Text = "Чизбургер";
            this.chizburg.UseVisualStyleBackColor = true;
            this.chizburg.Click += new System.EventHandler(this.chizburgqt_Click);
            // 
            // hamburg
            // 
            this.hamburg.AutoSize = true;
            this.hamburg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hamburg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hamburg.Location = new System.Drawing.Point(24, 94);
            this.hamburg.Name = "hamburg";
            this.hamburg.Size = new System.Drawing.Size(89, 17);
            this.hamburg.TabIndex = 4;
            this.hamburg.Text = "Гамбургер";
            this.hamburg.UseVisualStyleBackColor = true;
            this.hamburg.Click += new System.EventHandler(this.hamburg_Click);
            // 
            // hotdog
            // 
            this.hotdog.AutoSize = true;
            this.hotdog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hotdog.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hotdog.Location = new System.Drawing.Point(24, 67);
            this.hotdog.Name = "hotdog";
            this.hotdog.Size = new System.Drawing.Size(71, 17);
            this.hotdog.TabIndex = 3;
            this.hotdog.Text = "Хот-дог";
            this.hotdog.UseVisualStyleBackColor = true;
            this.hotdog.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // Kafeqts
            // 
            this.Kafeqts.AutoSize = true;
            this.Kafeqts.Location = new System.Drawing.Point(227, 33);
            this.Kafeqts.Name = "Kafeqts";
            this.Kafeqts.Size = new System.Drawing.Size(66, 13);
            this.Kafeqts.TabIndex = 2;
            this.Kafeqts.Text = "Количество";
            // 
            // Kafeprices
            // 
            this.Kafeprices.AutoSize = true;
            this.Kafeprices.Location = new System.Drawing.Point(114, 33);
            this.Kafeprices.Name = "Kafeprices";
            this.Kafeprices.Size = new System.Drawing.Size(33, 13);
            this.Kafeprices.TabIndex = 1;
            this.Kafeprices.Text = "Цена";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Kafepay);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(23, 206);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(291, 84);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "К оплате";
            // 
            // Kafepay
            // 
            this.Kafepay.Enabled = false;
            this.Kafepay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kafepay.Location = new System.Drawing.Point(19, 22);
            this.Kafepay.Name = "Kafepay";
            this.Kafepay.Size = new System.Drawing.Size(251, 45);
            this.Kafepay.TabIndex = 0;
            this.Kafepay.Tag = "1";
            this.Kafepay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Kafepay.TextChanged += new System.EventHandler(this.topay_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(52, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(284, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 31);
            this.label12.TabIndex = 3;
            this.label12.Text = "Итого:";
            // 
            // rezultsum
            // 
            this.rezultsum.Enabled = false;
            this.rezultsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rezultsum.Location = new System.Drawing.Point(385, 357);
            this.rezultsum.Name = "rezultsum";
            this.rezultsum.Size = new System.Drawing.Size(251, 60);
            this.rezultsum.TabIndex = 4;
            this.rezultsum.Tag = "1";
            this.rezultsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.rezultsum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Супер заправка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Topay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fuelprice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Amountsum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Litersqt;
        private System.Windows.Forms.RadioButton Amountcheck;
        private System.Windows.Forms.RadioButton Literscheck;
        private System.Windows.Forms.Label Fuelpricelb;
        private System.Windows.Forms.Label Fueltype;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kolaqt;
        private System.Windows.Forms.TextBox kolaprs;
        private System.Windows.Forms.TextBox chizburgqt;
        private System.Windows.Forms.TextBox chizburgprs;
        private System.Windows.Forms.TextBox hamburgqt;
        private System.Windows.Forms.TextBox hamburgprs;
        private System.Windows.Forms.TextBox hotdogqt;
        private System.Windows.Forms.TextBox hotdogprs;
        private System.Windows.Forms.CheckBox kola;
        private System.Windows.Forms.CheckBox chizburg;
        private System.Windows.Forms.CheckBox hamburg;
        private System.Windows.Forms.CheckBox hotdog;
        private System.Windows.Forms.Label Kafeqts;
        private System.Windows.Forms.Label Kafeprices;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Kafepay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox rezultsum;
        internal System.Windows.Forms.ComboBox Fuel;
    }
}

