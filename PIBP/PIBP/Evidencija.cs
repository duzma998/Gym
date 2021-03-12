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
    public partial class Evidencija : Form
    {
        public Evidencija()
        {
            InitializeComponent();
        }

        private void Evidencija_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataEvidencije1.EVIDENCIJE' table. You can move, or remove it, as needed.
            this.eVIDENCIJETableAdapter.Fill(this.dataEvidencije1.EVIDENCIJE);

        }
    }
}
