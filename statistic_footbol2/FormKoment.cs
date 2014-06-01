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
    public partial class FormKoment : Form
    {
        public FormKoment()
        {
            InitializeComponent();
            textBox1.Text = Data.nameg;
            textBox2.Text = Data.komm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Data.nameg = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Data.komm = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
