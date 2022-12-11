namespace my_character_tracker.Models
{
    public class OverwatchProfile
    {
        public Guid CharacterId { get; set; }
        public int CharacterIntId { get; set; }
        public string? Name { get; set; }
        public int Level { get; set; }
        public int HoursPlayedAllModes { get; set; }
        public int GamesPlayedAllModes { get; set; }
        public int GamesWonAllModes { get; set; }
        public int EliminationsAllModes { get; set; }
        public int AssistsAllModes { get; set; }
        public int KillStreakBestAllModes { get; set; }
        public DateTime CharacterCreated { get; set; }
        // Possibly add 'time played' per character.
        public DateTime AddedToDatabase { get; set; }
        public string? Game { get; set; } = "Overwatch 2";
    }
}
