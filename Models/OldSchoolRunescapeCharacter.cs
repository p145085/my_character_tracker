namespace my_character_tracker.Models
{
    public class OldSchoolRunescapeCharacter
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public int CombatLevel { get; set; }
        public int MaxLevelFree { get; set; } = 1395;
        public int MaxLevelMembers { get; set; } = 1782;
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Old School Runescape";
    }
}
