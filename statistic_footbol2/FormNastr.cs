using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace statistic_footbol2
{
    public partial class FormNastr : Form
    {
        public FormNastr()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Data.flStatField = checkField.Checked;
            Data.flStatTeam = checkTeam.Checked;
            Close();
        }
    }
}
