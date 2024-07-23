﻿namespace MatchdayMadness2.Models
{
    public class Standings
    {
        public int id { get; set; }
        public string Position { get; set; }
        public string Team { get; set; }
        public int Points { get; set; }
        public int MatchesPlayed { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
        public int Draws { get; set; }
        public int GoalDifference { get; set; }
    }
}
