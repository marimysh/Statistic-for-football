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
    public partial class Spravka : Form
    {
        public Spravka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Suprize secondForm = new Suprize();
            secondForm.Show();
            Close();
        }
    }
}
