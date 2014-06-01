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
    public partial class Formgoal : Form
    {
        public Formgoal()
        {
            InitializeComponent();
            if (!FormMain.StatusAssist)
            {
                textBox2.Text = "-";
                textBox2.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormMain.StatusTeamGoal)
            {
                Data.PlGoal1[FormMain.CountBall1] = textBox1.Text;
                Data.PlAssistant1[FormMain.CountBall1++] = textBox2.Text;
            }
            else
            {
                Data.PlGoal2[FormMain.CountBall2] = textBox1.Text;
                Data.PlAssistant2[FormMain.CountBall2++] = textBox2.Text;
            }
            Close();
        }
    }
}