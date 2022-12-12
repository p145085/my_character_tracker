namespace my_character_tracker.Models
{
    public class UltimaOnlineOutlandsCharacter
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public string? Name { get; set; }
        public string? TemplateDescription { get; set; }
        public List<KeyValuePair<string, SkillValues>>? Skills { get; set; }
        public int? SkillCapUOO = 700;
        public int? SkillCapUOOSkillBalls = 720;
        public int? LongtermMurders { get; set; }
        public int? TournamentMatches { get; set; }
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Ultima Online Outlands";
    }
}
