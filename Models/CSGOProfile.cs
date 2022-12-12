namespace my_character_tracker.Models
{
    public class CSGOProfile
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public int Level { get; set; }
        public string? HighestRankAchieved { get; set; }
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Counter Strike: Global Offensive";
    }
}
