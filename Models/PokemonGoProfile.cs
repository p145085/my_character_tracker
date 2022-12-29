namespace my_character_tracker.Models
{
    public class PokemonGoProfile
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public int MaxLevel { get; set; } = 50;
        public double? DistanceWalked { get; set; }
        public int? PokemonCaught { get; set; }
        public int? PokemonStops { get; set; }
        public int? Experience { get; set; }
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Pokemon Go";
    }
}
