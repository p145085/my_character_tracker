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
        public DbSet<UltimaOnlineCharacter>? UOCharacters { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
