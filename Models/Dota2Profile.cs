namespace my_character_tracker.Models
{
    public class Dota2Profile
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public int MaxLevel { get; set; }
        public string? Region { get; set; }
        public int? GamesPlayed { get; set; }
        public DateTime ProfileCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Defense of the Ancients 2";
    }
}
