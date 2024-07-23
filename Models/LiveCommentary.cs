namespace MatchdayMadness2.Models
{
    public class LiveCommentary
    {
        public int id { get; set; }
        public string Commentator { get; set; }
        public string DescriptiveText { get; set; }
        public bool RealTimeUpdates { get; set; }
    }
}
