using my_character_tracker.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace my_character_tracker.Data
{
    public class FooContext : DbContext
    {
        public FooContext() : base("FooContext")
        {

        }
        public DbSet<WoWCharacter>? WoWCharacters { get; set; }
        public DbSet<PoECharacter>? PoECharacters { get; set; }
        public DbSet<UltimaOnlineSecondageCharacter>? UOSACharacters { get; set; }
        public DbSet<UltimaOnlineOutlandsCharacter>? UOOCharacters { get; set; }
        public DbSet<D2RCharacter>? D2RCharacters { get; set; }
        public DbSet<NewWorldCharacter>? NewWorldCharacters { get; set; }
        public DbSet<GuildWars2Character>? GW2Characters { get; set; }
        public DbSet<ArcheageCharacter>? ArcheageCharacters { get; set; }
        public DbSet<HearthstoneCharacter>? HearthstoneCharacters { get; set; }
        public DbSet<OverwatchProfile>? OverwatchProfiles { get; set; }
        public DbSet<HeroesOfTheStormCharacter>? heroesOfTheStormCharacters { get; set; }
        public DbSet<CSGOProfile>? CSGOProfiles { get; set; }
        public DbSet<Dota2Profile>? Dota2Profiles { get; set; }
        public DbSet<QuakeLiveProfile>? QuakeLiveProfiles { get; set; }
        public DbSet<OldSchoolRunescapeCharacter>? oldSchoolRunescapeCharacters { get; set; }
        public DbSet<RunescapeCharacter>? runescapeCharacters { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
