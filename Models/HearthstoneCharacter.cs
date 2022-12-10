namespace my_character_tracker.Models
{
    public class HearthstoneCharacter
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public int Level { get; set; }
        public string? Class { get; set; }
        public int? Wins { get; set; }
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; }
    }
}
