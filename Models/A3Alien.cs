namespace my_character_tracker.Models
{
    public class A3Alien
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public int MaxLevel { get; set; } = 500;
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Alien Adoption Agency";
    }
}
