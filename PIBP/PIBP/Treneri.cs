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
    public partial class Treneri : Form
    {
        public Treneri()
        {
            InitializeComponent();
        }

        private void Treneri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataTreneri.TRENERI' table. You can move, or remove it, as needed.
            this.tRENERITableAdapter.Fill(this.dataTreneri.TRENERI);

        }

        private void tRENERIBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            this.tRENERITableAdapter.Update(this.dataTreneri);
        }
    }
}
