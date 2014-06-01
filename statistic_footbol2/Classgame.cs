using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace statistic_footbol2
{
    public class Team
    {
        public string NameTeam1 { get; set; }
        public string NameTeam2 { get; set; }
        public string NameGame { get; set; }
        public string Komment { get; set; }
        public int[] statistica = new int [12];                 //гол, пенальти, неудачное пенальти,
                                                                //удары по воротам, в створ, фолы, угловые, 
                                                                //офсайды, жк, кк, атаки, сейвы вратаря
        public string[] PlayersGoal = new string[15];
        public string[] Assistant = new string[15];
        public string[] StatusGoal = new string[15];
        public int[] Half = new int[15];
        public int CountBall { get; set; }
        public int PositionBall { get; set; }
        public int[] Position = new int[3];

        public Team()
        {
            NameTeam1 = "";
            NameTeam2 = "";
            NameGame = "";
            Komment = "";
            CountBall = 0;
            PositionBall = 0;
            statistica = new int[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            PlayersGoal = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            Assistant = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            StatusGoal = new string[15] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            Half = new int[15] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Position = new int[3] { 0, 0, 0 };
        }

        ~Team()
        {   }
    }
}
