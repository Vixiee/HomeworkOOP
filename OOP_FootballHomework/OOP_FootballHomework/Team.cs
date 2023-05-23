using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_FootballHomework
{
    public class Team  
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }
        public double AverageAge()
        {
            int sum = 0;
            foreach (FootballPlayer player in Players)
            {
                sum = sum + player.Age;
            }
            return (double) sum / Players.Count;
        }

    }
}
