using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace statistic_footbol2
{
    static class Data
    {
        public static string nameg { get; set; }
        public static string komm { get; set; }
        public static string[] PlGoal1 = new string[15];
        public static string[] PlAssistant1 = new string[15];
        public static string[] PlGoal2 = new string[15];
        public static string[] PlAssistant2 = new string[15];
        public static bool flStatTeam, flStatField;
        public static List<Team> Games = new List<Team>();
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
