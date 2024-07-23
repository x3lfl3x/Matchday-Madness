namespace MatchdayMadness2.Models
{
    public class Matches
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public string Stadium { get; set; }
        public string Status { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Result { get; set; }
        public virtual List<Players> Players { get; set; }
        public virtual List<Favorites> Favorites { get; set; } 
    }
}
