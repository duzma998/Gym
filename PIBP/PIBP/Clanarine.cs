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
    public partial class Clanarine : Form
    {
        public Clanarine()
        {
            InitializeComponent();
        }

        private void Clanarine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataClanarine.CLANARINE' table. You can move, or remove it, as needed.
            this.cLANARINETableAdapter.Fill(this.dataClanarine.CLANARINE);

        }
    }
}
