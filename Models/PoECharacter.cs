namespace my_character_tracker.Models
{
    public class PoECharacter
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public int MaxLevel { get; set; } = 100;
        public string? Class { get; set; }
        public bool? IsHardcore { get; set; }
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Path of Exile";
    }
}
