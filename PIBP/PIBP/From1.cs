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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Username.Text.Equals("Admin") && Password.Text.Equals("Admin"))
            {
                this.Hide();
                Menu m2 = new Menu();
                m2.Show();
            }
            else
            {
                MessageBox.Show("Netacan Username Ili Password", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
