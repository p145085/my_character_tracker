namespace my_character_tracker.Models
{
    public class CoDWZ2Profile
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public string? CharacterName { get; set; }
        public int Level { get; set; }
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Call of Duty: Warzone 2.0";
    }
}
