namespace PERSONELL
{
    partial class Form2
    {
  
        private System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
        }

        #region Windows Form Designer generated code

        
        private void InitializeComponent()
        {
            tb_Ad = new TextBox();
            tb_Soyad = new TextBox();
            tb_Mail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label4 = new Label();
            //comboBox1 = new ComboBox();
            label5 = new Label();
            //button1 = new Button();
            EkBilgi = new ListBox();
            comboBox2 = new ComboBox();
            label6 = new Label();
            tb_Tc = new TextBox();
            label7 = new Label();
            monthCalendar1 = new MonthCalendar();
            //button2 = new Button();
            // 
            // tb_Ad
            // 
            tb_Ad.Location = new Point(70, 12);
            tb_Ad.Name = "tb_Ad";
            tb_Ad.Size = new Size(174, 27);
            tb_Ad.TabIndex = 0;
            // 
            // tb_Soyad
            // 
            tb_Soyad.Location = new Point(70, 75);
            tb_Soyad.Name = "tb_Soyad";
            tb_Soyad.Size = new Size(175, 27);
            tb_Soyad.TabIndex = 1;
            // 
            // tb_Mail
            // 
            tb_Mail.Location = new Point(69, 133);
            tb_Mail.Name = "tb_Mail";
            tb_Mail.Size = new Size(175, 27);
            tb_Mail.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 19);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 3;
            label1.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 82);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 140);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 5;
            label3.Text = "Mail";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(576, 35);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 24);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(576, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(68, 24);
            radioButton2.TabIndex = 7;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 12);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 8;
            label4.Text = "Cinsiyet";

            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Adana - 01", "Adıyaman - 02", "Afyonkarahisar - 03", "Ağrı - 04", "Amasya - 05", "Ankara - 06", "Antalya - 07", "Artvin - 08", "Aydın - 09", "Balıkesir - 10", "Bilecik - 11", "Bingöl - 12", "Bitlis - 13", "Bolu - 14", "Burdur - 15", "Bursa - 16", "Çanakkale - 17", "Çankırı - 18", "Çorum - 19", "Denizli - 20", "Diyarbakır - 21", "Edirne - 22", "Elazığ - 23", "Erzincan - 24", "Erzurum - 25", "Eskişehir - 26", "Gaziantep - 27", "Giresun - 28", "Gümüşhane - 29", "Hakkari - 30", "Hatay - 31", "Isparta - 32", "Mersin - 33", "İstanbul - 34", "İzmir - 35", "Kars - 36", "Kastamonu - 37", "Kayseri - 38", "Kırklareli - 39", "Kırşehir - 40", "Kocaeli - 41", "Konya - 42", "Kütahya - 43", "Malatya - 44", "Manisa - 45", "K.maraş - 46", "Mardin - 47", "Muğla - 48", "Muş - 49", "Nevşehir - 50", "Niğde - 51", "Ordu - 52", "Rize - 53", "Sakarya - 54", "Samsun - 55", "Siirt - 56", "Sinop - 57", "Sivas - 58", "Tekirdağ - 59", "Tokat - 60", "Trabzon - 61", "Tunceli - 62", "Şanlıurfa - 63", "Uşak - 64", "Van - 65", "Yozgat - 66", "Zonguldak - 67", "Aksaray - 68", "Bayburt - 69", "Karaman - 70", "Kırıkkale - 71", "Batman - 72", "Şırnak - 73", "Bartın - 74", "Ardahan - 75", "Iğdır - 76", "Yalova - 77", "Karabük - 78", "Kilis - 79", "Osmaniye - 80", "Düzce - 81" });
            comboBox1.Location = new Point(70, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 10;

            


            label5.AutoSize = true;
            label5.Location = new Point(8, 187);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 11;
            label5.Text = "Şehir";



            button1.Location = new Point(327, 279);
            button1.Name = "button1";
            button1.Size = new Size(149, 73);
            button1.TabIndex = 12;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            


            EkBilgi.FormattingEnabled = true;
            EkBilgi.Location = new Point(530, 202);
            EkBilgi.Name = "EkBilgi";
            EkBilgi.Size = new Size(230, 164);
            EkBilgi.TabIndex = 13;

            


            comboBox2.AccessibleName = "";
            comboBox2.BackColor = SystemColors.HighlightText;
            comboBox2.ForeColor = SystemColors.MenuText;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Çalışan ", "Güvenlik", "Hizmetli", "Müdür ", "Öğrenci", "Stajyer ", "Yönetici" });
            comboBox2.Location = new Point(530, 137);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(190, 28);
            comboBox2.Sorted = true;
            comboBox2.TabIndex = 14;

            


            label6.AutoSize = true;
            label6.Location = new Point(477, 141);
            label6.Name = "label6";
            label6.Size = new Size(30, 20);
            label6.TabIndex = 15;
            label6.Text = "Tür";

          


            tb_Tc.Location = new Point(69, 248);
            tb_Tc.Name = "tb_Tc";
            tb_Tc.Size = new Size(196, 27);
            tb_Tc.TabIndex = 16;

            


            label7.AutoSize = true;
            label7.Location = new Point(19, 251);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 17;
            label7.Text = "TC";

            


            monthCalendar1.Location = new Point(12, 299);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 18;

            


            button2.Location = new Point(327, 402);
            button2.Name = "button2";
            button2.Size = new Size(156, 67);
            button2.TabIndex = 19;
            button2.Text = "LİSTEYİ GÖSTER";
            button2.UseVisualStyleBackColor = true;

            Form1

           //AutoScaleDimensions = new SizeF(8F, 20F);
           // AutoScaleMode = AutoScaleMode.Font;
           // ClientSize = new Size(800, 545);
           // Controls.Add(button2);
           // Controls.Add(monthCalendar1);
           // Controls.Add(label7);
           // Controls.Add(tb_Tc);
           // Controls.Add(label6);
           // Controls.Add(comboBox2);
            //Controls.Add(EkBilgi);
            //Controls.Add(button1);
            //Controls.Add(label5);
            //Controls.Add(comboBox1);
            //Controls.Add(label4);
            //Controls.Add(radioButton2);
            //Controls.Add(radioButton1);
            //Controls.Add(label3);
            //Controls.Add(label2);
            //Controls.Add(label1);
            //Controls.Add(tb_Mail);
            //Controls.Add(tb_Soyad);
            //Controls.Add(tb_Ad);
            //Name = "Form1";
            //Text = "Form1";
            //Load += Form1_Load;
            //ResumeLayout(false);
            //PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private ListBox EkBilgi;
        private Label label6;
        private Label label7;
        private Button button2;
        public TextBox tb_Ad;
        public TextBox tb_Soyad;
        public TextBox tb_Mail;
        public RadioButton radioButton1;
        public RadioButton radioButton2;
        public ComboBox comboBox1;
        public ComboBox comboBox2;
        public TextBox tb_Tc;
        public MonthCalendar monthCalendar1;
    }
}
