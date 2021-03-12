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
    public partial class Treninzi : Form
    {
        public Treninzi()
        {
            InitializeComponent();
        }

        private void Treninzi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataTreninzi.TRENINZI' table. You can move, or remove it, as needed.
            this.tRENINZITableAdapter.Fill(this.dataTreninzi.TRENINZI);

        }

        private void tRENINZIBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            try
            {
                this.tRENINZITableAdapter.Update(this.dataTreninzi);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greska u unosu", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
