﻿using my_character_tracker.Models;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace my_character_tracker.Data
{
    public class InitialData : System.Data.Entity.DropCreateDatabaseIfModelChanges<FooContext>
    {
        protected override void Seed(FooContext context)
        {
            var POE = new List<PoECharacter>
            {
                new PoECharacter
                {
                    Name="DANGERBICEPSFLEMING",
                    Level=78,
                    Class="Witch",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="FRIFIRFIR",
                    Level=64,
                    Class="Raider",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="GENJIXAXA",
                    Level=42,
                    Class="Shadow",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="HIBIDIBIDOBI",
                    Level=35,
                    Class="Ranger",
                    IsHardcore=true
                },
                new PoECharacter
                {
                    Name="IDONTKNOWENGLISH",
                    Level=23,
                    Class="Witch",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="JUGGALOKATYPERRY",
                    Level=72,
                    Class="Witch",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="KKKKKKKKKFG",
                    Level=25,
                    Class="Ranger",
                    IsHardcore=true
                },
                new PoECharacter
                {
                    Name="KOALAMURRELEY",
                    Level=65,
                    Class="Marauder",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="PEWERERAA",
                    Level=89,
                    Class="Berserker",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="PROXYBOXXY",
                    Level=59,
                    Class="Assassin",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="REVERBL",
                    Level=30,
                    Class="Witch",
                    IsHardcore=true
                },
                new PoECharacter
                {
                    Name="SAGGAERGAERGA",
                    Level=77,
                    Class="Deadeye",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="SATANSBEE",
                    Level=23,
                    Class="Scion",
                    IsHardcore=true
                },
                new PoECharacter
                {
                    Name="SEVENOOSSEVENOOS",
                    Level=83,
                    Class="Scion",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="SLINGEROFPEBBLES",
                    Level=62,
                    Class="Templar",
                    IsHardcore=true
                },
                new PoECharacter
                {
                    Name="SPERURURU",
                    Level=53,
                    Class="Witch",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="STRINGFOO",
                    Level=46,
                    Class="Witch",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="SUPERDOGE",
                    Level=81,
                    Class="Scion",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="TEELAAAAAAAAAAA",
                    Level=49,
                    Class="Witch",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="THUNDERJANE",
                    Level=50,
                    Class="Ranger",
                    IsHardcore=true
                },
                new PoECharacter
                {
                    Name="THWOSRT",
                    Level=71,
                    Class="Marauder",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="TWIDDLESTICKSMCGEE",
                    Level=88,
                    Class="Assassin",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="VAPENVAPEN",
                    Level=44,
                    Class="Slayer",
                    IsHardcore=false
                },
                new PoECharacter
                {
                    Name="WTFIMCH",
                    Level=56,
                    Class="Scion",
                    IsHardcore=false
                }
            };

            var D2R = new List<D2RCharacter>
            {
                // Diablo 2: Resurrected
                new D2RCharacter
                {
                    Name="BARACKA",
                    Level=3,
                    Class="Barbarian",
                    Title=null,
                    IsOnline=true,
                    AddedToDatabase=DateTime.Now,
                    Game="Diablo 2: Resurrected",
                },
                new D2RCharacter
                {
                    Name="BABARARUPHA",
                    Level=6,
                    Class="Barbarian",
                    Title=null,
                    IsOnline=true,
                    AddedToDatabase=DateTime.Now,
                    Game="Diablo 2: Resurrected",
                },
                new D2RCharacter
                {
                    Name="HOHOHO",
                    Level=12,
                    Class="Sorceress",
                    Title=null,
                    IsOnline=true,
                    AddedToDatabase=DateTime.Now,
                    Game="Diablo 2: Resurrected",
                },
                new D2RCharacter
                {
                    Name="DROODOLOLLEE",
                    Level=40,
                    Class="Druid",
                    Title="Slayer",
                    IsOnline=true,
                    AddedToDatabase=DateTime.Now,
                    Game="Diablo 2: Resurrected",
                },
                new D2RCharacter
                {
                    Name="MULEMULEMULE",
                    Level=1,
                    Class="Barbarian",
                    IsOnline=true,
                    AddedToDatabase=DateTime.Now,
                    Game="Diablo 2: Resurrected",
                },
                new D2RCharacter
                {
                    Name="STASHMASTER",
                    Level=3,
                    Class="Amazon",
                    IsOnline=true,
                    AddedToDatabase=DateTime.Now,
                    Game="Diablo 2: Resurrected",
                },
                new D2RCharacter
                {
                    Name="CARDANOADA",
                    Level=82,
                    Class="Sorceress",
                    Title="Matriarch",
                    IsOnline=true,
                    AddedToDatabase=DateTime.Now,
                    Game="Diablo 2: Resurrected",
                },
                new D2RCharacter
                {
                    Name="LAPPAHLAPAPP",
                    Level=91,
                    Class="Paladin",
                    Title="Patriarch",
                    IsOnline=true,
                    AddedToDatabase=DateTime.Now,
                    Game="Diablo 2: Resurrected",
                },
                new D2RCharacter
                {
                    Name="POPULUS",
                    Level=53,
                    Class="Sorceress",
                    Title="Slayer",
                    IsOnline=true,
                    AddedToDatabase=DateTime.Now,
                    Game="Diablo 2: Resurrected",
                },
            };

            // World of Warcraft
            var WoW = new List<WoWCharacter>
            {
                // Realm: Burning Legion
                new WoWCharacter{
                    Name="Krossarn",
                    Level=50,
                    Class="Warrior",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Legion"
                },
                new WoWCharacter{
                    Name="Populus",
                    Level=60,
                    Class="Rogue",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Legion"
                },
                new WoWCharacter{
                    Name="Bartimaeus",
                    Level=51,
                    Class="Mage",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Legion"
                },
                new WoWCharacter{
                    Name="Kellerman",
                    Level=20,
                    Class="Hunter",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Legion"
                },
                new WoWCharacter{
                    Name="Generaisnus",
                    Level=20,
                    Class="Warlock",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Legion"
                },
                new WoWCharacter{
                    Name="Lachance",
                    Level=5,
                    Class="Shaman",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Legion"
                },
                new WoWCharacter{
                    Name="Voodoohex",
                    Level=20,
                    Class="Priest",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Legion"
                },
                new WoWCharacter{
                    Name="Leavehimtome",
                    Level=23,
                    Class="Death Knight",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Legion"
                },
                new WoWCharacter{
                    Name="Matrondemoo",
                    Level=20,
                    Class="Paladin",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Legion"
                },
                new WoWCharacter{
                    Name="Colaburken",
                    Level=14,
                    Class="Druid",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Legion"
                },

                // Realm: Tarren Mill
                new WoWCharacter{
                    Name="Mitoshi",
                    Level=60,
                    Class="Priest",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Tarren Mill"
                },
                new WoWCharacter{
                    Name="Gustafvasa",
                    Level=40,
                    Class="Demon Hunter",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Tarren Mill"
                },
                new WoWCharacter{
                    Name="Duacron",
                    Level=50,
                    Class="Shaman",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Tarren Mill"
                },
                new WoWCharacter{
                    Name="Clemenceii",
                    Level=0,
                    Class="Class Trial Completed",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Tarren Mill"
                },
                new WoWCharacter{
                    Name="Turororo",
                    Level=0,
                    Class="Class Trial In Progress",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Tarren Mill"
                },

                // Realm: Trollbane
                new WoWCharacter{
                    Name="Gulleplutten",
                    Level=1,
                    Class="Shaman",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Trollbane"
                },
                new WoWCharacter{
                    Name="Alanpran",
                    Level=24,
                    Class="Paladin",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Trollbane"
                },
                new WoWCharacter{
                    Name="Mitoshi",
                    Level=30,
                    Class="Priest",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Trollbane"
                },
                new WoWCharacter{
                    Name="Leftsock",
                    Level=4,
                    Class="Warlock",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Trollbane"
                },

                // Realm: Ravencrest
                new WoWCharacter{
                    Name="Tobbe",
                    Level=2,
                    Class="Warrior",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Ravencrest"
                },
                new WoWCharacter{
                    Name="Populus",
                    Level=11,
                    Class="Mage",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Ravencrest"
                },
                new WoWCharacter{
                    Name="Bobkebab",
                    Level=3,
                    Class="Priest",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Ravencrest"
                },
                new WoWCharacter{
                    Name="Spadiee",
                    Level=1,
                    Class="Warlock",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Ravencrest"
                },

                // Realm: Burning Blade
                new WoWCharacter{
                    Name="Someoneelse",
                    Level=4,
                    Class="Hunter",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Blade"
                },
                new WoWCharacter{
                    Name="Huhrhga",
                    Level=1,
                    Class="Warrior",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Blade"
                },
                new WoWCharacter{
                    Name="Populus",
                    Level=7,
                    Class="Priest",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Burning Blade"
                },

                // Realm: Bloodhoof
                new WoWCharacter{
                    Name="Bartimaêus",
                    Level=25,
                    Class="Warlock",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Bloodhoof"
                },
                
                // Realm: Emerald Dream
                new WoWCharacter{
                    Name="Krigsl7E13C9",
                    Level=7,
                    Class="Warlock",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Emerald Dream"
                },

                // Realm: Jaedenar
                new WoWCharacter{
                    Name="Spík",
                    Level=26,
                    Class="Death Knight",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Jaedenar"
                },

                // Realm: Alleria
                new WoWCharacter{
                    Name="Populus",
                    Level=2,
                    Class="Warrior",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Alleria"
                },

                // Realm: Antonidas
                new WoWCharacter{
                    Name="Populus",
                    Level=2,
                    Class="Warrior",
                    AddedToDatabase=DateTime.Now,
                    Game="World of Warcraft (Retail)",
                    Realm="Antonidas"
                },
            };
            WoW.ForEach(character => context.WoWCharacters.Add(character));
            context.SaveChanges();
            
            // Ultima Online (SKILLS-LISTS)
            var sgtdinklebirchskills = new List<KeyValuePair<string, SkillValues>>();
            sgtdinklebirchskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Animal Taming",
                    new SkillValues
                    {
                        Value = 101.6,
                        CurrentCap = 105,
                        MaxCap = 120
                    }
                )
            );
            sgtdinklebirchskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Animal Lore",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            sgtdinklebirchskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Peacemaking",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            sgtdinklebirchskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Veterinary",
                    new SkillValues
                    {
                        Value = 95.5,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            sgtdinklebirchskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Musicianship",
                    new SkillValues
                    {
                        Value = 94.9,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            sgtdinklebirchskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Meditation",
                    new SkillValues
                    {
                        Value = 85.5,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            sgtdinklebirchskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 66.9,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            sgtdinklebirchskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Anatomy",
                    new SkillValues
                    {
                        Value = 55.6,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );

            var jeanskills = new List<KeyValuePair<string, SkillValues>>();
            jeanskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Mining",
                    new SkillValues
                    {
                        Value = 100.3,
                        CurrentCap = 110,
                        MaxCap = 120
                    }
                )
            );
            jeanskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Camping",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            jeanskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tracking",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            jeanskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Wrestling",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            jeanskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Lumberjacking",
                    new SkillValues
                    {
                        Value = 97.2,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            jeanskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Swordsmanship",
                    new SkillValues
                    {
                        Value = 56.5,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            jeanskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 56,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            jeanskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Archery",
                    new SkillValues
                    {
                        Value = 50.1,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );

            var anullplayerskills = new List<KeyValuePair<string, SkillValues>>();
            anullplayerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Forensics",
                    new SkillValues
                    {
                        Value = 120,
                        CurrentCap = 120,
                        MaxCap = 120
                    }
                )
            );
            anullplayerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Parrying",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            anullplayerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            anullplayerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Wrestling",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            anullplayerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Camping",
                    new SkillValues
                    {
                        Value = 90,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            anullplayerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Resisting Spells",
                    new SkillValues
                    {
                        Value = 80,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            anullplayerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Meditation",
                    new SkillValues
                    {
                        Value = 60,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            anullplayerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Evaluating Intelligence",
                    new SkillValues
                    {
                        Value = 50,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );

            var barklundskills = new List<KeyValuePair<string, SkillValues>>();
            barklundskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Evaluating Intelligence",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            barklundskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            barklundskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tactics",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            barklundskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Swordsmanship",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            barklundskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Wrestling",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            barklundskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Meditation",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            barklundskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Resisting Spells",
                    new SkillValues
                    {
                        Value = 82.8,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );

            var konsumskills = new List<KeyValuePair<string, SkillValues>>();
            konsumskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tracking",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            konsumskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Mace Fighting",
                    new SkillValues
                    {
                        Value = 94.5,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            konsumskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tactics",
                    new SkillValues
                    {
                        Value = 92.9,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            konsumskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Peacemaking",
                    new SkillValues
                    {
                        Value = 87.1,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            konsumskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Discordance",
                    new SkillValues
                    {
                        Value = 84.1,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            konsumskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Musicianship",
                    new SkillValues
                    {
                        Value = 83.1,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            konsumskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Arms Lore",
                    new SkillValues
                    {
                        Value = 80.4,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            konsumskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Healing",
                    new SkillValues
                    {
                        Value = 77.9,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );

            var georgeskills = new List<KeyValuePair<string, SkillValues>>();
            georgeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Anatomy",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            georgeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Parrying",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            georgeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Healing",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            georgeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tactics",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            georgeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Fencing",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            georgeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Resisting Spells",
                    new SkillValues
                    {
                        Value = 91.5,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            georgeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 50.7,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            georgeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Arms Lore",
                    new SkillValues
                    {
                        Value = 47.6,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );

            var twindleskills = new List<KeyValuePair<string, SkillValues>>();
            twindleskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Mining",
                    new SkillValues
                    {
                        Value = 100.5,
                        CurrentCap = 110,
                        MaxCap = 120
                    }
                )
            );
            twindleskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Camping",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            twindleskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tracking",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            twindleskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Wrestling",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            twindleskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Lumberjacking",
                    new SkillValues
                    {
                        Value = 94.5,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            twindleskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 55.3,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            twindleskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Swordsmanship",
                    new SkillValues
                    {
                        Value = 52.9,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            twindleskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Archery",
                    new SkillValues
                    {
                        Value = 50.1,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            twindleskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tactics",
                    new SkillValues
                    {
                        Value = 41.6,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );

            var cartwrightskills = new List<KeyValuePair<string, SkillValues>>();
            cartwrightskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Lock Picking",
                    new SkillValues
                    {
                        Value = 118,
                        CurrentCap = 120,
                        MaxCap = 120
                    }
                )
            );
            cartwrightskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Remove Trap",
                    new SkillValues
                    {
                        Value = 116,
                        CurrentCap = 116,
                        MaxCap = 120
                    }
                )
            );
            cartwrightskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Detecting Hidden",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 111,
                        MaxCap = 120
                    }
                )
            );
            cartwrightskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Hiding",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            cartwrightskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tinkering",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 107,
                        MaxCap = 120
                    }
                )
            );
            cartwrightskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Stealth",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            cartwrightskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 66,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );

            var murdockskills = new List<KeyValuePair<string, SkillValues>>();
            murdockskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Evaluating Intelligence",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            murdockskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            murdockskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tactics",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            murdockskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Swordsmanship",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            murdockskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Meditation",
                    new SkillValues
                    {
                        Value = 86.9,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            murdockskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Resisting Spells",
                    new SkillValues
                    {
                        Value = 80.1,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            murdockskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Alchemy",
                    new SkillValues
                    {
                        Value = 72.7,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            murdockskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Poisoning",
                    new SkillValues
                    {
                        Value = 60.3,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );

            var awildslowpokeskills = new List<KeyValuePair<string, SkillValues>>();
            awildslowpokeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Evaluating Intelligence",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            awildslowpokeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Hiding",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            awildslowpokeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            awildslowpokeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Wrestling",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            awildslowpokeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Meditation",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            awildslowpokeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Stealth",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            awildslowpokeskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Resisting Spells",
                    new SkillValues
                    {
                        Value = 70.3,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );

            var gabriellaskills = new List<KeyValuePair<string, SkillValues>>();
            gabriellaskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Hiding",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            gabriellaskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Snooping",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            gabriellaskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Stealing",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            gabriellaskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Stealth",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            gabriellaskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Parrying",
                    new SkillValues
                    {
                        Value = 80,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            gabriellaskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 80,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            gabriellaskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Wrestling",
                    new SkillValues
                    {
                        Value = 78.4,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            gabriellaskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Meditation",
                    new SkillValues
                    {
                        Value = 61.6,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );

            var dangertamerskills = new List<KeyValuePair<string, SkillValues>>();
            dangertamerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Animal Lore",
                    new SkillValues
                    {
                        Value = 115,
                        CurrentCap = 116,
                        MaxCap = 120
                    }
                )
            );
            dangertamerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Animal Taming",
                    new SkillValues
                    {
                        Value = 115,
                        CurrentCap = 115,
                        MaxCap = 120
                    }
                )
            );
            dangertamerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            dangertamerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Wrestling",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            dangertamerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Meditation",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            dangertamerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Evaluating Intelligence",
                    new SkillValues
                    {
                        Value = 80,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            dangertamerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Resisting Spells",
                    new SkillValues
                    {
                        Value = 70,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            dangertamerskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Alchemy",
                    new SkillValues
                    {
                        Value = 20,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );

            var populusskills = new List<KeyValuePair<string, SkillValues>>();
            populusskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Evaluating Intelligence",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            populusskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            populusskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tactics",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            populusskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Swordsmanship",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            populusskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Wrestling",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            populusskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Meditation",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            populusskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Resisting Spells",
                    new SkillValues
                    {
                        Value = 81.5,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            populusskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Anatomy",
                    new SkillValues
                    {
                        Value = 18.3,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );

            var afrenziedharpyskills = new List<KeyValuePair<string, SkillValues>>();
            afrenziedharpyskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tailoring",
                    new SkillValues
                    {
                        Value = 102,
                        CurrentCap = 102,
                        MaxCap = 120
                    }
                )
            );
            afrenziedharpyskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Item Identification",
                    new SkillValues
                    {
                        Value = 61.6,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            afrenziedharpyskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tinkering",
                    new SkillValues
                    {
                        Value = 60.8,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            afrenziedharpyskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Blacksmithing",
                    new SkillValues
                    {
                        Value = 60.1,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            afrenziedharpyskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Carpentry",
                    new SkillValues
                    {
                        Value = 50.3,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            afrenziedharpyskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Cartography",
                    new SkillValues
                    {
                        Value = 50,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            afrenziedharpyskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 50,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );

            var jazzybeatskills = new List<KeyValuePair<string, SkillValues>>();
            jazzybeatskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Anatomy",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            jazzybeatskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Hiding",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            jazzybeatskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Tactics",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            jazzybeatskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Swordsmanship",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            jazzybeatskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Stealth",
                    new SkillValues
                    {
                        Value = 100,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            jazzybeatskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Animal Lore",
                    new SkillValues
                    {
                        Value = 75.2,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            jazzybeatskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Animal Taming",
                    new SkillValues
                    {
                        Value = 75,
                        CurrentCap = 100,
                        MaxCap = 120
                    }
                )
            );
            jazzybeatskills.Add(
                new KeyValuePair<string, SkillValues>(
                    "Magery",
                    new SkillValues
                    {
                        Value = 49,
                        CurrentCap = 100,
                        MaxCap = 100
                    }
                )
            );
            // Ultima Online (CHARACTER-LISTS)
            var UOO = new List<UltimaOnlineCharacter>
            {
                new UltimaOnlineCharacter
                {
                    Name = "Sgt Dinkle Birch",
                    TemplateDescription = "Veterinary-tamer",
                    Skills = sgtdinklebirchskills,
                    CharacterCreated = DateTime.Parse("2019-01-12"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "Jean",
                    TemplateDescription = "Gatherer",
                    Skills = jeanskills,
                    CharacterCreated = DateTime.Parse("2019-01-16"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "a null player",
                    TemplateDescription = "Skinner, capable survivalist and moderate damage output.",
                    Skills = anullplayerskills,
                    CharacterCreated = DateTime.Parse("2022-09-26"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "Barklund",
                    TemplateDescription = "Tankmage, designed for T2A PvP.",
                    Skills = barklundskills,
                    CharacterCreated = DateTime.Parse("2019-01-16"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "Konsum",
                    TemplateDescription = "Peacemaking and Discordance macing-bard.",
                    Skills = konsumskills,
                    CharacterCreated = DateTime.Parse("2020-01-07"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "George",
                    TemplateDescription = "Fencing and Parrying dexxer with magery.",
                    Skills = georgeskills,
                    CharacterCreated = DateTime.Parse("2019-01-12"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "Twindle",
                    TemplateDescription = "Gatherer",
                    Skills = twindleskills,
                    CharacterCreated = DateTime.Parse("2019-01-13"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "Cartwright",
                    TemplateDescription = "T-mapper, lockpicker.",
                    Skills = cartwrightskills,
                    CharacterCreated = DateTime.Parse("2019-01-14"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "Murdock",
                    TemplateDescription = "Tankmage w. alchemy & poisoning.",
                    Skills = murdockskills,
                    CharacterCreated = DateTime.Parse("2019-01-19"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "a wild slowpoke",
                    TemplateDescription = "Stealth-archer",
                    Skills = awildslowpokeskills,
                    CharacterCreated = DateTime.Parse("2020-04-12"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "Gabriella",
                    TemplateDescription = "Thief",
                    Skills = gabriellaskills,
                    CharacterCreated = DateTime.Parse("2019-01-12"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "Danger Tamer",
                    TemplateDescription = "Eval-tamer",
                    Skills = dangertamerskills,
                    CharacterCreated = DateTime.Parse("2022-02-21"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "Populus",
                    TemplateDescription = "Tankmage designed for T2A PvP.",
                    Skills = populusskills,
                    CharacterCreated = DateTime.Parse("2019-01-19"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "a frenzied harpy",
                    TemplateDescription = "Crafter",
                    Skills = afrenziedharpyskills,
                    CharacterCreated = DateTime.Parse("2019-02-10"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                },
                new UltimaOnlineCharacter
                {
                    Name = "Jazzy Beat",
                    TemplateDescription = "Hally-stealth-PK with Taming and spiders.",
                    Skills = jazzybeatskills,
                    CharacterCreated = DateTime.Parse("2019-07-12"),
                    AddedToDatabase = DateTime.Now,
                    Game = "Ultima Online Outlands"
                }
            };
            UOO.ForEach(character => context.UOCharacters.Add(character));
            context.SaveChanges();
            
            // Path of Exile
            var PoE = new List<PoECharacter>
            {
                new PoECharacter{
                    Name="SEVENOOSSEVENOOS",
                    Level=83,
                    AddedToDatabase=DateTime.Now,
                    Game="Path of Exile (Standard)"
                }
            };
            PoE.ForEach(character => context.PoECharacters.Add(character));
            context.SaveChanges();
        }
    }
}
