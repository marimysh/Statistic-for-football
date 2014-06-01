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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }

        string nameh, namegh;
        int goal1 = 0, goal2 = 0, penalty1 = 0, penalty2 = 0, udarvor1 = 0, udarvor2 = 0,
            udarstv1 = 0, udarstv2 = 0, fol1 = 0, fol2 = 0, ugl1 = 0, ugl2 = 0, ofs1 = 0,
            ofs2 = 0, attak1 = 0, attak2 = 0, savegoal1 = 0, savegoal2 = 0,
            zhk1 = 0, zhk2 = 0, kk1 = 0, kk2 = 0, failpen1 = 0, failpen2 = 0;
        int fl = 0, HalfGame = 0;
        public static int CountBall1 = 0, CountBall2 = 0;
        string[] StatusGoal1 = new string[15];
        string[] StatusGoal2 = new string[15];
        public static bool StatusTeamGoal, StatusAssist;
        int CountTimePosition = 0, Field = 1, CountTimeGame = 0;
        int[] Position1 = new int[3] {0, 1, 0};
        int[] Position2 = new int[3] {0, 1, 0};
        bool flTeam;
        public static int[] Half1 = new int[15];
        public static int[] Half2 = new int[15];


        
        private void button1_Click(object sender, EventArgs e)
        {
            goal1 += 1 - fl;
            labelgoal1.Text = goal1.ToString();
            label4.Text = goal1.ToString();
            StatusAssist = true;
            Formgoal secondForm = new Formgoal();
            secondForm.Show();
            Half1[CountBall1] = HalfGame;
            StatusGoal1[CountBall1]="Goal";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            udarvor1 += 1 - fl;
            label5.Text = udarvor1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            udarstv1 += 1 - fl;
            label6.Text = udarstv1.ToString();
            udarvor1 += 1 - fl;
            label5.Text = udarvor1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fol1 += 1 - fl;
            label7.Text = fol1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ugl1 += 1 - fl;
            label8.Text = ugl1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ofs1 += 1 - fl;
            label9.Text = ofs1.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zhk1 += 1 - fl;
            label10.Text = zhk1.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kk1 += 1 - fl;
            label11.Text = kk1.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            penalty1 += 1 - fl;
            goal1 += 1 - fl;
            labelgoal1.Text = goal1.ToString();
            label12.Text = penalty1.ToString();
            StatusTeamGoal = true;
            StatusAssist = false;
            Formgoal secondForm = new Formgoal();
            secondForm.Show();
            Half1[CountBall1] = HalfGame;
            StatusGoal1[CountBall1] = "penalty";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            failpen1 += 1 - fl;
            label13.Text = failpen1.ToString();
            Formgoal secondForm = new Formgoal();
            StatusTeamGoal = true;
            StatusAssist = false;
            secondForm.Show();
            Half1[CountBall1] = HalfGame;
            StatusGoal1[CountBall1] = "Fail penalty";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            goal2 += 1 - fl;
            labelgoal2.Text = goal2.ToString();
            label23.Text = goal2.ToString();
            StatusTeamGoal = false;
            StatusAssist = true;
            Formgoal secondForm = new Formgoal();
            secondForm.Show();
            Half2[CountBall2] = HalfGame;
            StatusGoal2 [CountBall2] = "Goal";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            udarvor2 += 1 - fl;
            label22.Text = udarvor2.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            udarstv2 += 1 - fl;
            label21.Text = udarstv2.ToString();
            udarvor2 += 1 - fl;
            label22.Text = udarvor2.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            fol2 += 1 - fl;
            label20.Text = fol2.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ugl2 += 1 - fl;
            label19.Text = ugl2.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ofs2 += 1 - fl;
            label18.Text = ofs2.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            zhk2 += 1 - fl;
            label17.Text = zhk2.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            kk2 += 1 - fl;
            label16.Text = kk2.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            penalty2 += 1 - fl;
            goal2 += 1 - fl;
            labelgoal2.Text = goal2.ToString();
            label15.Text = penalty2.ToString();
            StatusTeamGoal = false;
            StatusAssist = false;
            Formgoal secondForm = new Formgoal();
            secondForm.Show();
            Half2[CountBall2] = HalfGame;
            StatusGoal2 [CountBall2] = "penalty";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            failpen2 += 1 - fl;
            label14.Text = failpen2.ToString();
            StatusTeamGoal = false;
            StatusAssist = false;
            Formgoal secondForm = new Formgoal();
            secondForm.Show();
            Half2[CountBall2] = HalfGame;
            StatusGoal2 [CountBall2] = "Fail penalty";
        }

        private void nameHos_TextChanged(object sender, EventArgs e)
        {
            nameh = nameHos.Text;
        }

        private void namegost_TextChanged(object sender, EventArgs e)
        {
            namegh = namegost.Text;
        }

        private void прокомментироватьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKoment secondForm = new FormKoment();
            secondForm.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"D:\PrimGame1.txt", "");
            for (var i = 0; i < Data.Games.Count; ++i)
            {
                if (i % 2 == 0)
                    System.IO.File.AppendAllText(@"D:\PrimGame1.txt", "1;");
                else
                    System.IO.File.AppendAllText(@"D:\PrimGame1.txt", "2;");
                System.IO.File.AppendAllText(@"D:\PrimGame1.txt", Data.Games[i].NameGame + ";");
                System.IO.File.AppendAllText(@"D:\PrimGame1.txt", Data.Games[i].NameTeam1 + ";");
                System.IO.File.AppendAllText(@"D:\PrimGame1.txt", Data.Games[i].NameTeam2 + ";");
                for (var j = 0; j < 12; ++j)
                    System.IO.File.AppendAllText(@"D:\PrimGame1.txt", Data.Games[i].statistica[j].ToString() + ";");
                System.IO.File.AppendAllText(@"D:\PrimGame1.txt", Data.Games[i].Komment + ";");
                for (int j = 0; j < Data.Games[i].CountBall; ++j)
                {
                    System.IO.File.AppendAllText(@"D:\PrimGame1.txt", Data.Games[i].PlayersGoal[j] + " ");
                    System.IO.File.AppendAllText(@"D:\PrimGame1.txt", Data.Games[i].Assistant[j] + " ");
                    System.IO.File.AppendAllText(@"D:\PrimGame1.txt", Data.Games[i].StatusGoal[j] + " ");
                }
                System.IO.File.AppendAllText(@"D:\PrimGame1.txt", ";");
                for (int j = 0; j < 3; ++j)
                    System.IO.File.AppendAllText(@"D:\PrimGame1.txt", Data.Games[i].Position[j].ToString() + " ");
                System.IO.File.AppendAllText(@"D:\PrimGame1.txt", ";" + Data.Games[i].PositionBall.ToString());
                System.IO.File.AppendAllText(@"D:\PrimGame1.txt", ";\n");
            }
            Close();
        }

        private void отменитьДействияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fl = 2;
            отменитьДействияToolStripMenuItem.Visible = false;
            продолжитьВводитьДаныеToolStripMenuItem.Visible = true;
        }
         
        private void продолжитьВводитьДаныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fl = 0;
            отменитьДействияToolStripMenuItem.Visible = true;
            продолжитьВводитьДаныеToolStripMenuItem.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            attak1 += 1 - fl;
            label24.Text = attak1.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            attak2 += 1 - fl;
            label25.Text = attak2.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Position2[Field] += CountTimePosition;
            CountTimePosition = 0;
            if (!timerStat.Enabled)
                timerStat.Enabled = true;
            flTeam = true;
            RBG.Checked = false;
            RBH.Checked = true;
            int SumPos1 = Position1[0] + Position1[1] + Position1[2];
            int SumPos2 = Position2[0] + Position2[1] + Position2[2];
            label30.Text = ((SumPos1 * 100) / (SumPos1 + SumPos2)).ToString() + "%";
            label31.Text = (100 - (SumPos1 * 100) / (SumPos1 + SumPos2)).ToString() + "%";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            timerStat.Enabled = false;
            if (flTeam)
                Position1[Field] += CountTimePosition;
            else
                Position2[Field] += CountTimePosition;
            CountTimePosition = 0;
            int SumPos1 = Position1[0] + Position1[1] + Position1[2];
            int SumPos2 = Position2[0] + Position2[1] + Position2[2];
            label30.Text = ((SumPos1 * 100) / (SumPos1 + SumPos2)).ToString() + "%";
            label31.Text = (100 - (SumPos1 * 100) / (SumPos1 + SumPos2)).ToString() + "%";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Position1[Field] += CountTimePosition;
            CountTimePosition = 0;
            if (!timerStat.Enabled)
                timerStat.Enabled = true;
            flTeam = false;
            RBG.Checked = true;
            RBH.Checked = false;
            int SumPos1 = Position1[0] + Position1[1] + Position1[2];
            int SumPos2 = Position2[0] + Position2[1] + Position2[2];
            label30.Text = ((SumPos1 * 100) / (SumPos1 + SumPos2)).ToString() + "%";
            label31.Text = (100 - (SumPos1 * 100) / (SumPos1 + SumPos2)).ToString() + "%";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (flTeam)
            {
                Position1[Field] += CountTimePosition;
                int SumPos1 = Position1[0] + Position1[1] + Position1[2];
                label32.Text = ((Position1[0] * 100) / SumPos1).ToString() + "%";
                label33.Text = ((Position1[1] * 100) / SumPos1).ToString() + "%";
                label34.Text = (100 - (Position1[0] * 100) / SumPos1 - (Position1[1] * 100) / SumPos1).ToString() + "%";
            }
            else
            {
                Position2[Field] += CountTimePosition;
                int SumPos2 = Position2[0] + Position2[1] + Position2[2];
                label37.Text = ((Position2[0] * 100) / SumPos2).ToString() + "%";
                label36.Text = ((Position2[1] * 100) / SumPos2).ToString() + "%";
                label35.Text = (100 - (Position2[0] * 100) / SumPos2 - (Position2[1] * 100) / SumPos2).ToString() + "%";
            }
            RBp0.Checked = true;
            RBp1.Checked = false;
            RBp2.Checked = false;
            Field = 0;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (flTeam)
            {
                Position1[Field] += CountTimePosition;
                int SumPos1 = Position1[0] + Position1[1] + Position1[2];
                label32.Text = ((Position1[0] * 100) / SumPos1).ToString() + "%";
                label33.Text = ((Position1[1] * 100) / SumPos1).ToString() + "%";
                label34.Text = (100 - (Position1[0] * 100) / SumPos1 - (Position1[1] * 100) / SumPos1).ToString() + "%";
            }
            else
            {
                Position2[Field] += CountTimePosition;
                int SumPos2 = Position2[0] + Position2[1] + Position2[2];
                label37.Text = ((Position2[0] * 100) / SumPos2).ToString() + "%";
                label36.Text = ((Position2[1] * 100) / SumPos2).ToString() + "%";
                label35.Text = (100 - (Position2[0] * 100) / SumPos2 - (Position2[1] * 100) / SumPos2).ToString() + "%";
            }
            RBp0.Checked = false;
            RBp1.Checked = true;
            RBp2.Checked = false;
            Field = 1;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (flTeam)
            {
                Position1[Field] += CountTimePosition;
                int SumPos1 = Position1[0] + Position1[1] + Position1[2];
                label32.Text = ((Position1[0] * 100) / SumPos1).ToString() + "%";
                label33.Text = ((Position1[1] * 100) / SumPos1).ToString() + "%";
                label34.Text = (100 - (Position1[0] * 100) / SumPos1 - (Position1[1] * 100) / SumPos1).ToString() + "%";
            }
            else
            {
                Position2[Field] += CountTimePosition;
                int SumPos2 = Position2[0] + Position2[1] + Position2[2];
                label37.Text = ((Position2[0] * 100) / SumPos2).ToString() + "%";
                label36.Text = ((Position2[1] * 100) / SumPos2).ToString() + "%";
                label35.Text = (100 - (Position2[0] * 100) / SumPos2 - (Position2[1] * 100) / SumPos2).ToString() + "%";
            }
            RBp0.Checked = false;
            RBp1.Checked = false;
            RBp2.Checked = true;
            Field = 2;
        }

        private void статистикаПоВладениюМячемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNastr secondForm = new FormNastr();
            secondForm.Show();
            if (Data.flStatTeam)
            {
                button23.Visible = false;
                button24.Visible = false;
                button25.Visible = false;
            }
            else
            {
                button23.Visible = true;
                button24.Visible = true;
                button25.Visible = true;
            }
            if (Data.flStatField)
            {
                button26.Visible = false;
                button27.Visible = false;
                button28.Visible = false;
            }
            else
            {
                button26.Visible = true;
                button27.Visible = true;
                button28.Visible = true;
            }
            if (Data.flStatField && Data.flStatTeam)
            {
                Position1 = new int[3] { 0, 0, 0 };
                Position2 = new int[3] { 0, 0, 0 };
            }
        }
        
        private void следующийТаймToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerStat.Enabled = true;
            timerMinuts.Enabled = true;
        }

        private void конецИгрыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Team Gamenow = new Team();
            Team Gamenow2 = new Team();
            int SumPos1 = Position1[0] + Position1[1] + Position1[2];
            int SumPos2 = Position2[0] + Position2[1] + Position2[2];
            Gamenow.statistica[0] = goal1;
            Gamenow.statistica[1] = penalty1;
            Gamenow.statistica[2] = failpen1;
            Gamenow.statistica[3] = udarvor1;
            Gamenow.statistica[4] = udarstv1;
            Gamenow.statistica[5] = fol1;
            Gamenow.statistica[6] = ugl1;
            Gamenow.statistica[7] = ofs1;
            Gamenow.statistica[8] = attak1;
            Gamenow.statistica[9] = zhk1;
            Gamenow.statistica[10] = kk1;
            Gamenow.statistica[11] = savegoal1;
            Gamenow.NameTeam1 = nameh;
            Gamenow.NameTeam2 = namegh;
            Gamenow.CountBall = CountBall1;
            Gamenow.PositionBall = (SumPos1 * 100) / (SumPos1 + SumPos2);
            for (int i = 0; i < 3; ++i)
                Gamenow.Position[i] = (Position1[i] * 100) / SumPos1;
            Gamenow.NameGame = Data.nameg;
            Gamenow.Komment = Data.komm;
            for (int i = 0; i <= CountBall1; ++i)
            {
                Gamenow.PlayersGoal[i] = Data.PlGoal1[i];
                Gamenow.Assistant[i] = Data.PlAssistant1[i];
                Gamenow.StatusGoal[i] = StatusGoal1[i];
                Gamenow.Half[i] = Half1[i];
            }
            Data.Games.Add(Gamenow);

            Gamenow2.statistica[0] = goal2;
            Gamenow2.statistica[1] = penalty2;
            Gamenow2.statistica[2] = failpen2;
            Gamenow2.statistica[3] = udarvor2;
            Gamenow2.statistica[4] = udarstv2;
            Gamenow2.statistica[5] = fol2;
            Gamenow2.statistica[6] = ugl2;
            Gamenow2.statistica[7] = ofs2;
            Gamenow2.statistica[8] = attak2;
            Gamenow2.statistica[9] = zhk2;
            Gamenow2.statistica[10] = kk2;
            Gamenow2.statistica[11] = savegoal2;
            Gamenow2.CountBall = CountBall2;
            Gamenow2.PositionBall = 100 - Gamenow.PositionBall;
            for (int i = 0; i < 3; ++i)
                Gamenow2.Position[i] = (Position2[i] * 100) / SumPos2;

            Gamenow2.NameTeam1 = nameh;
            Gamenow2.NameTeam2 = namegh;
            Gamenow2.NameGame = Data.nameg;
            Gamenow2.Komment = Data.komm;
            for (int i = 0; i < CountBall2; ++i)
            {
                Gamenow2.PlayersGoal[i] = Data.PlGoal2[i];
                Gamenow2.Assistant[i] = Data.PlAssistant2[i];
                Gamenow2.StatusGoal[i] = StatusGoal2[i];
                Gamenow2.Half[i] = Half2[i];
            }
            Gamenow2.CountBall = CountBall2;
            Data.Games.Add(Gamenow2);

            goal1 = 0;
            goal2 = 0;
            penalty1 = 0;
            penalty2 = 0;
            udarvor1 = 0;
            udarvor2 = 0;
            udarstv1 = 0;
            udarstv2 = 0;
            fol1 = 0;
            fol2 = 0;
            ugl1 = 0;
            ugl2 = 0;
            ofs1 = 0;
            ofs2 = 0;
            zhk1 = 0;
            zhk2 = 0;
            kk1 = 0;
            kk2 = 0;
            failpen1 = 0;
            failpen2 = 0;
            attak1 = 0;
            attak2 = 0;
            savegoal1 = 0;
            savegoal2 = 0;
            labelgoal1.Text = "0";
            labelgoal2.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            label17.Text = "0";
            label18.Text = "0";
            label19.Text = "0";
            label20.Text = "0";
            label21.Text = "0";
            label22.Text = "0";
            label23.Text = "0";
            label24.Text = "0";
            label25.Text = "0";
            label28.Text = "0";
            label29.Text = "0";
            Data.PlGoal1 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            Data.PlAssistant1 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            StatusGoal1 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            Data.PlGoal2 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            Data.PlAssistant2 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            StatusGoal2 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            Half1 = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Half2 = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            HalfGame = 0;
            Position1 = new int[3] { 0, 0, 0 };
            Position2 = new int[3] { 0, 0, 0 };
            CountTimeGame = 0;
            CountTimePosition = 0;
            CountBall1 = 0;
            CountBall2 = 0;
            label27.Text = "0:0";
            timerStat.Enabled = false;
            timerMinuts.Enabled = false;
        }

        private void начатьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goal1 = 0;
            goal2 = 0;
            penalty1 = 0;
            penalty2 = 0;
            udarvor1 = 0;
            udarvor2 = 0;
            udarstv1 = 0;
            udarstv2 = 0;
            fol1 = 0;
            fol2 = 0;
            ugl1 = 0;
            ugl2 = 0;
            ofs1 = 0;
            ofs2 = 0;
            attak1 = 0;
            attak2 = 0;
            savegoal1 = 0;
            savegoal2 = 0;
            zhk1 = 0;
            zhk2 = 0;
            kk1 = 0;
            kk2 = 0;
            failpen1 = 0;
            failpen2 = 0;
            labelgoal1.Text = "0";
            labelgoal2.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            label9.Text = "0";
            label10.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            label13.Text = "0";
            label14.Text = "0";
            label15.Text = "0";
            label16.Text = "0";
            label17.Text = "0";
            label18.Text = "0";
            label19.Text = "0";
            label20.Text = "0";
            label21.Text = "0";
            label22.Text = "0";
            label23.Text = "0";
            label24.Text = "0";
            label25.Text = "0";
            label28.Text = "0";
            label29.Text = "0";
            Data.PlGoal1 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            Data.PlAssistant1 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            StatusGoal1 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            Data.PlGoal2 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            Data.PlAssistant2 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            StatusGoal2 = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            Half1 = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Half2 = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            HalfGame = 0;
            Position1 = new int[3] { 0, 0, 0 };
            Position2 = new int[3] { 0, 0, 0 };
            CountTimeGame = 0;
            CountTimePosition = 0;
            CountBall1 = 0;
            CountBall2 = 0;
            label27.Text = "0:0";
            timerStat.Enabled = false;
            timerMinuts.Enabled = false;
        }

        private void слToolStripMenuItem_Click(object sender, EventArgs e)    
        {
            timerStat.Enabled = true;
            timerMinuts.Enabled = true;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            savegoal1 += 1 - fl;
            label28.Text = savegoal1.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            savegoal2 += 1 - fl;
            label29.Text = savegoal2.ToString();
        }

        private void timerMinuts_Tick(object sender, EventArgs e)
        {
            label27.Text = (CountTimeGame / 60).ToString() + ":" + (CountTimeGame % 60).ToString();
            CountTimeGame++;
        }

        private void конецТаймаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HalfGame++;
            CountTimeGame = HalfGame * 45 * 60;
            timerStat.Enabled = false;
            timerMinuts.Enabled = false;
            label27.Text = (CountTimeGame / 60).ToString() + ":" + (CountTimeGame % 60).ToString();
        }

        private void timerStat_Tick(object sender, EventArgs e)
        {
            CountTimePosition++;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spravka secondForm = new Spravka();
            secondForm.Show();
        }
    }
}