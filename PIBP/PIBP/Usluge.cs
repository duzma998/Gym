﻿using System;
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
    public partial class Usluge : Form
    {
        public Usluge()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Usluge_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataUsluge.USLUGE' table. You can move, or remove it, as needed.
            this.uSLUGETableAdapter.Fill(this.dataUsluge.USLUGE);

        }
    }
}
