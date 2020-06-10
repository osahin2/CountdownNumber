using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YY_OneOperation
{
    public partial class SecimForm : Form
    {
        public static Random rnd = new Random();
        public static int[]sayilar = new int[6];
        public static int hedef = 0;
        public static int enIyıSecim = 0;
        public static int puan = 0;
        public static double kacSaniye = 0;

        public SecimForm()
        {
            InitializeComponent();
        }

        private void xuıFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {
            Hesapla_btn.Enabled = false;
        }

        private void Hesapla_btn_Click(object sender, EventArgs e)
        {

            sayilar[0] = int.Parse(sayi1_txt.Text);
            sayilar[1] = int.Parse(sayi2_txt.Text);
            sayilar[2] = int.Parse(sayi3_txt.Text);
            sayilar[3] = int.Parse(sayi4_txt.Text);
            sayilar[4] = int.Parse(sayi5_txt.Text);
            sayilar[5] = int.Parse(sayi6_txt.Text);
            hedef = int.Parse(Hedef_txt.Text);

            DateTime baslangicZaman = DateTime.Now;

            while (true)
            {
                kacSaniye = (DateTime.Now - baslangicZaman).TotalSeconds;

                int sayi = rnd.Next(6);
                int temp = sayilar[sayi];
                sayilar[sayi] = sayilar[0];
                sayilar[0] = temp;

                int Toplam = sayilar[0];
                string sonuc = sayilar[0].ToString();
                int sayiDongu = rnd.Next(1, 7);

                for(int i = 1; i < sayiDongu; i++)
                {
                    int islem = rnd.Next(4);
                    if(islem==0)
                    {
                        Toplam += sayilar[i];
                        sonuc += "+" + sayilar[i].ToString();
                    }
                    if(islem==1)
                    {
                        Toplam -= sayilar[i];
                        sonuc += "-" + sayilar[i].ToString();
                    }
                    if(islem==2)
                    {
                        Toplam *= sayilar[i];
                        sonuc += "*" + sayilar[i].ToString();
                    }
                    if(islem==3)
                    {
                        if (Toplam % sayilar[i] !=0) continue;
                        Toplam /= sayilar[i];
                        sonuc += "/" + sayilar[i].ToString();
                    }
                }
                sonuc += "=" + Toplam.ToString();
                if(Toplam==hedef)
                {
                    puan += 10;
                    Sonuc_lbl.Text = "Sonuc:" + sonuc;
                    puan_lbl.Text = "Puan:" + puan;
                    break;
                }
                if (kacSaniye >= 3)
                {
                    Sonuc_lbl.Text = "Sonuc:Sonuc Bulunamadi.";
                    break;
                }

            }
        }

        private void Kontrol_btn_Click(object sender, EventArgs e)
        {
            if (sayi1_txt.Text == "" || int.Parse(sayi1_txt.Text) > 9)
            {
                Hata_lbl.Visible = true;
            }
            else if (sayi2_txt.Text == "" || int.Parse(sayi2_txt.Text) > 9)
            {
                Hata_lbl.Visible = true;
            }
            else if (sayi3_txt.Text == "" || int.Parse(sayi3_txt.Text) > 9)
            {
                Hata_lbl.Visible = true;
            }
            else if (sayi4_txt.Text == "" || int.Parse(sayi4_txt.Text) > 9)
            {
                Hata_lbl.Visible = true;
            }
            else if (sayi5_txt.Text == "" || int.Parse(sayi5_txt.Text) > 9)
            {
                Hata_lbl.Visible = true;
            }
            else if (sayi6_txt.Text == "" || int.Parse(sayi6_txt.Text) < 9 || int.Parse(sayi6_txt.Text) > 99 || int.Parse(sayi6_txt.Text) % 10 != 0)
            {
                Hata_lbl.Visible = true;
            }
            else if (Hedef_txt.Text == "" || int.Parse(Hedef_txt.Text) < 100)
            {
                Hata_lbl.Visible = true;
            }
            else
            {
                Hata_lbl.Visible = false;
            }

            if (Hata_lbl.Visible == false)
            {
                Hesapla_btn.Enabled = true;
            }
        }

        private void oncekiSayfa_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 AnaMenu = new Form1();
            AnaMenu.Show();
        }
    }
}
