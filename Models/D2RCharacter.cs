namespace my_character_tracker.Models
{
    public class D2RCharacter
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public int MaxLevel { get; set; } = 99;
        public string? Class { get; set; }
        public string? Title { get; set; }
        public bool IsOnline { get; set; }
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Diablo 2: Resurrected";
    }
}
