using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIBP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clanovi c1 = new Clanovi();
            c1.Show();
       
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Treneri t1 = new Treneri();
            t1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Treninzi t2 = new Treninzi();
            t2.Show();
    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Evidencija e1 = new Evidencija();
            e1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Usluge u1 = new Usluge();
            u1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clanarine c11 = new Clanarine();
            c11.Show();
        }
    }
}
