namespace MatchdayMadness2.Models
{
    public class Notifications
    {
        public int id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public bool IsRead { get; set; }
    }
}
