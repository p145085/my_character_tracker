namespace my_character_tracker.Models
{
    public class QuakeLiveProfile
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public string? CharacterName { get; set; }
        public int Kills { get; set; }
        public int GamesPlayed { get; set; }
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Quake Live";
    }
}
