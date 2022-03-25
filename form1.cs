using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latihan_pbo_2
{
    public partial class Form1 : Form
    {
        Kalkulator kalkulator = new Kalkulator();
        public Form1()
        {
            InitializeComponent();
            Status.Items.Add("Tambah");
            Status.Items.Add("Kurang");


        }

        private void Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            kalkulator.A = Convert.ToDouble(Angka1.Text);
            kalkulator.B = Convert.ToDouble(Angka2.Text);

            if(Status.SelectedIndex == 0)
            {
                angka3.Text = kalkulator.Tambah(kalkulator.A, kalkulator.B).ToString();
            }
            else if(Status.SelectedIndex == 1)
            {
                angka3.Text = kalkulator.Kurang(kalkulator.A, kalkulator.B).ToString();
            }
        }
    }
}
