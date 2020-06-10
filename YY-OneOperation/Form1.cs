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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Secim_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecimForm sf = new SecimForm();
            sf.Show();
        }

        private void Rnd_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RandomForm rf = new RandomForm();
            rf.Show();
        }
    }
}
