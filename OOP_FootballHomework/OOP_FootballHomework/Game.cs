using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_FootballHomework
{
    public class Game  
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<AsistentReferee> AsistantReferees { get; set; }
        public List<Goal> Goals { get; set; }
        public Team Winner { get; set; }
        public string GameResult { get; set; }
       
    }
}
