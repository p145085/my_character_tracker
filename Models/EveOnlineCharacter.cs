namespace my_character_tracker.Models
{
    public class EveOnlineCharacter
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public string? Name { get; set; }
        public int? SkillPoints { get; set; }
        public double? SecurityStatus { get; set; }
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Eve Online";
    }
}
