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
    public partial class RandomForm : Form
    {

        public static Random rnd = new Random();
        public static int[] sayilar = new int[6];
        public static int hedef = 0;
        public static int enIyıSecim = 0;
        public static int puan = 0;
        public static double kacSaniye = 0;

        public RandomForm()
        {
            InitializeComponent();
        }

        private void xuıFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void xuıButton1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                sayilar[i] = rnd.Next(1, 9);
            }
            sayilar[5] = rnd.Next(1, 9)*10;
            hedef = rnd.Next(100, 999);

            rnd1_lbl.Text = "1.Random Sayi:" + sayilar[0];
            rnd2_lbl.Text = "2.Random Sayi:" + sayilar[1];
            rnd3_lbl.Text = "3.Random Sayi:" + sayilar[2];
            rnd4_lbl.Text = "4.Random Sayi:" + sayilar[3];
            rnd5_lbl.Text = "5.Random Sayi:" + sayilar[4];
            rnd6_lbl.Text = "6.Random Sayi:" + sayilar[5];
            rndHedef_lbl.Text = "Random Hedef:" + hedef;

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

                for (int i = 1; i < sayiDongu; i++)
                {
                    int islem = rnd.Next(4);
                    if (islem == 0)
                    {
                        Toplam += sayilar[i];
                        sonuc += "+" + sayilar[i].ToString();
                    }
                    if (islem == 1)
                    {
                        Toplam -= sayilar[i];
                        sonuc += "-" + sayilar[i].ToString();
                    }
                    if (islem == 2)
                    {
                        Toplam *= sayilar[i];
                        sonuc += "*" + sayilar[i].ToString();
                    }
                    if (islem == 3)
                    {
                        if (Toplam % sayilar[i] != 0)
                        {
                            continue;
                        }

                        Toplam /= sayilar[i];
                        sonuc += "/" + sayilar[i].ToString();
                    }
                }
                sonuc += "=" + Toplam.ToString();

                if (Math.Abs(hedef - Toplam) < Math.Abs(hedef - enIyıSecim))
                {
                    enIyıSecim = Toplam;
                }
                if (Toplam == hedef)
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

        private void xuıButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 AnaMenu = new Form1();
            AnaMenu.Show();
        }
    }
}
