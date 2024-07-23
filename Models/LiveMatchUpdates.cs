namespace MatchdayMadness2.Models
{
    public class LiveMatchUpdates
    {
        public int id { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int CurrenScoreHome { get; set; }
        public int CurrenScoreAway { get; set; }
        public DateTime CurrentTime { get; set; }


    }
}
