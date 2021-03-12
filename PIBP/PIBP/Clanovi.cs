using Oracle.ManagedDataAccess.Client;
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
    public partial class Clanovi : Form
    {
        public Clanovi()
        {
            InitializeComponent();
        }

        private void Clanovi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataClanovi.CLANOVI' table. You can move, or remove it, as needed.
            this.cLANOVITableAdapter.Fill(this.dataClanovi.CLANOVI);



        }

        private void cLANOVIBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.cLANOVITableAdapter.Update(this.dataClanovi);
        }
    }
}
