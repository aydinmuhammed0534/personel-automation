using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;
namespace PERSONELL
{
    public partial class Form2;

    {
        public Form2()
        {
            InitializeComponent();

        }

        TextControl tcontrotcontrol = new TextControl();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1(string ad, string soyad, string tc,
            string mail, string tur)
        {
            InitializeComponent();
            tb_Ad.Text = ad;
            tb_Soyad.Text = soyad;
            tb_Tc.Text = tc;
            tb_Mail.Text = mail;
            comboBox2.Text = tur;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string isim = tb_Ad.Text;
            string Soyisim = tb_Soyad.Text;
            string Mail = tb_Mail.Text;
            string Cinsiyet = "";
            string Sehir = "";
            string Tc = tb_Tc.Text;
            string tarih = monthCalendar1.SelectionRange.Start.Date.ToShortDateString();
            string Tur = "";
            string dizinadresi = "C:\\Veri\\";

            if (!tcontrol.isValidEmail(Mail))
            {
                MessageBox.Show("Geçersiz Mail");
                return;
            }

            if (!tcontrol.isValidMobileNumber(Tc))
            {
                MessageBox.Show("11 haneli TC Giriniz ve Rakamlardan Oluþsun");
                return;
            }

            #region Ifadeleri Kaydet
            if (comboBox1.SelectedIndex > 0)
            {
                if (comboBox2.SelectedIndex > 0)
                {
                    if (isim != "" && tcontrol.YaziKontrol(isim))
                    {
                        if (Soyisim != "" && tcontrol.YaziKontrol(Soyisim))
                        {
                            if (Tc != "" && tcontrol.TCKontrol(Tc))
                            {
                                Sehir = comboBox1.GetItemText(comboBox1.SelectedItem.ToString());
                                Tur = comboBox2.GetItemText(comboBox2.SelectedItem.ToString());

                                if (radioButton1.Checked == true)
                                    Cinsiyet = radioButton1.Text;
                                else
                                    Cinsiyet = radioButton2.Text;

                                DateTimeFormatInfo tr = new CultureInfo("tr-TR", false).DateTimeFormat;
                                string result = Convert.ToDateTime(monthCalendar1.SelectionStart.ToString()).ToString(tr);

                                if (!Directory.Exists(dizinadresi))
                                    Directory.CreateDirectory(dizinadresi);

                                using StreamWriter Yaz = new StreamWriter(dizinadresi + "Yaz.txt", true);

                                Yaz.Write("" + isim);
                                Yaz.Write("," + Soyisim);
                                Yaz.Write("," + Mail);
                                Yaz.Write("," + Sehir);
                                Yaz.Write("," + tarih);
                                Yaz.Write("," + Tc);
                                Yaz.Write("," + Cinsiyet);
                                Yaz.Write("," + Tur);

                                Yaz.WriteLine();
                                Yaz.Close();

                                MessageBox.Show("Baþarýyla kaydedildi..");
                            }
                            else
                            {
                                MessageBox.Show("Lütfen Doðru TC Giriniz veya boþ býrakmayýnýz");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Soyisminiz geçersiz karakter içeriyor veya boþ býrakmayýnýz");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ýsminiz geçersiz karakter içeriyor veya boþ býrakmayýnýz");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Seçim Yapýnýz");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Þehir Seçiniz..");
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextControl textControl = new TextControl();
            Form frm = new Form(textControl);
            frm.ShowDialog();
        }

        


        //private void InitializeComponent()
        //{
        //    tb_Ad = new TextBox();
        //    tb_Soyad = new TextBox();
        //    tb_Tc = new TextBox();
        //    tb_Mail = new TextBox();
        //    comboBox1 = new ComboBox();
        //    comboBox2 = new ComboBox();
        //    radioButton1 = new RadioButton();
        //    radioButton2 = new RadioButton();
        //    monthCalendar1 = new MonthCalendar();
        //    label1 = new Label();
        //    label2 = new Label();
        //    label3 = new Label();
        //    label4 = new Label();
        //    label5 = new Label();
        //    label6 = new Label();
        //    button1 = new Button();
        //    button2 = new Button();
        //    SuspendLayout();
        //    // 
        //    // tb_Ad
        //    // 
        //    tb_Ad.Location = new Point(63, 12);
        //    tb_Ad.Name = "tb_Ad";
        //    tb_Ad.Size = new Size(167, 27);
        //    tb_Ad.TabIndex = 0;
        //    // 
        //    // tb_Soyad
        //    // 
        //    tb_Soyad.Location = new Point(63, 82);
        //    tb_Soyad.Name = "tb_Soyad";
        //    tb_Soyad.Size = new Size(178, 27);
        //    tb_Soyad.TabIndex = 1;
        //    // 
        //    // tb_Tc
        //    // 
        //    tb_Tc.Location = new Point(58, 289);
        //    tb_Tc.Name = "tb_Tc";
        //    tb_Tc.Size = new Size(183, 27);
        //    tb_Tc.TabIndex = 3;
        //    // 
        //    // tb_Mail
        //    // 
        //    tb_Mail.Location = new Point(63, 155);
        //    tb_Mail.Name = "tb_Mail";
        //    tb_Mail.Size = new Size(178, 27);
        //    tb_Mail.TabIndex = 4;
        //    // 
        //    // comboBox1
        //    // 
        //    comboBox1.FormattingEnabled = true;
        //    comboBox1.Location = new Point(63, 230);
        //    comboBox1.Name = "comboBox1";
        //    comboBox1.Size = new Size(173, 28);
        //    comboBox1.TabIndex = 5;
        //    // 
        //    // comboBox2
        //    // 
        //    comboBox2.FormattingEnabled = true;
        //    comboBox2.Location = new Point(721, 204);
        //    comboBox2.Name = "comboBox2";
        //    comboBox2.Size = new Size(226, 28);
        //    comboBox2.TabIndex = 6;
        //    // 
        //    // radioButton1
        //    // 
        //    radioButton1.AutoSize = true;
        //    radioButton1.Location = new Point(752, 41);
        //    radioButton1.Name = "radioButton1";
        //    radioButton1.Size = new Size(73, 24);
        //    radioButton1.TabIndex = 7;
        //    radioButton1.TabStop = true;
        //    radioButton1.Text = "ERKEK";
        //    radioButton1.UseVisualStyleBackColor = true;
        //    // 
        //    // radioButton2
        //    // 
        //    radioButton2.AutoSize = true;
        //    radioButton2.Location = new Point(752, 71);
        //    radioButton2.Name = "radioButton2";
        //    radioButton2.Size = new Size(75, 24);
        //    radioButton2.TabIndex = 8;
        //    radioButton2.TabStop = true;
        //    radioButton2.Text = "KADIN";
        //    radioButton2.UseVisualStyleBackColor = true;
        //    // 
        //    // monthCalendar1
        //    // 
        //    monthCalendar1.Location = new Point(38, 338);
        //    monthCalendar1.Name = "monthCalendar1";
        //    monthCalendar1.TabIndex = 9;
        //    // 
        //    // label1
        //    // 
        //    label1.AutoSize = true;
        //    label1.Location = new Point(7, 15);
        //    label1.Name = "label1";
        //    label1.Size = new Size(50, 20);
        //    label1.TabIndex = 10;
        //    label1.Text = "label1";
        //    // 
        //    // label2
        //    // 
        //    label2.AutoSize = true;
        //    label2.Location = new Point(7, 89);
        //    label2.Name = "label2";
        //    label2.Size = new Size(50, 20);
        //    label2.TabIndex = 11;
        //    label2.Text = "label2";
        //    // 
        //    // label3
        //    // 
        //    label3.AutoSize = true;
        //    label3.Location = new Point(7, 158);
        //    label3.Name = "label3";
        //    label3.Size = new Size(50, 20);
        //    label3.TabIndex = 12;
        //    label3.Text = "label3";
        //    // 
        //    // label4
        //    // 
        //    label4.AutoSize = true;
        //    label4.Location = new Point(2, 233);
        //    label4.Name = "label4";
        //    label4.Size = new Size(50, 20);
        //    label4.TabIndex = 13;
        //    label4.Text = "label4";
        //    // 
        //    // label5
        //    // 
        //    label5.AutoSize = true;
        //    label5.Location = new Point(2, 296);
        //    label5.Name = "label5";
        //    label5.Size = new Size(50, 20);
        //    label5.TabIndex = 14;
        //    label5.Text = "label5";
        //    // 
        //    // label6
        //    // 
        //    label6.AutoSize = true;
        //    label6.Location = new Point(643, 212);
        //    label6.Name = "label6";
        //    label6.Size = new Size(50, 20);
        //    label6.TabIndex = 15;
        //    label6.Text = "label6";
        //    // 
        //    // button1
        //    // 
        //    button1.Location = new Point(512, 289);
        //    button1.Name = "button1";
        //    button1.Size = new Size(124, 59);
        //    button1.TabIndex = 16;
        //    button1.Text = "button1";
        //    button1.UseVisualStyleBackColor = true;
        //    button1.Click += button1_Click_1;
        //    // 
        //    // button2
        //    // 
        //    button2.Location = new Point(512, 396);
        //    button2.Name = "button2";
        //    button2.Size = new Size(124, 71);
        //    button2.TabIndex = 17;
        //    button2.Text = "button2";
        //    button2.UseVisualStyleBackColor = true;
        //    // 
        //    // Form1
        //    // 
        //    ClientSize = new Size(1084, 667);
        //    Controls.Add(button2);
        //    Controls.Add(button1);
        //    Controls.Add(label6);
        //    Controls.Add(label5);
        //    Controls.Add(label4);
        //    Controls.Add(label3);
        //    Controls.Add(label2);
        //    Controls.Add(label1);
        //    Controls.Add(monthCalendar1);
        //    Controls.Add(radioButton2);
        //    Controls.Add(radioButton1);
        //    Controls.Add(comboBox2);
        //    Controls.Add(comboBox1);
        //    Controls.Add(tb_Mail);
        //    Controls.Add(tb_Tc);
        //    Controls.Add(tb_Soyad);
        //    Controls.Add(tb_Ad);
        //    Name = "Form1";
        //    ResumeLayout(false);
        //    PerformLayout();
        //}

        //private TextBox tb_Mail;
        //private ComboBox comboBox1;
        //private ComboBox comboBox2;
        //private RadioButton radioButton1;
        //private RadioButton radioButton2;
        //private MonthCalendar monthCalendar1;
        //private Label label1;
        //private Label label2;
        //private Label label3;
        //private Label label4;
        //private Label label5;
        //private Label label6;
        //private Button button1;
        //private Button button2;

        //private void button1_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}


