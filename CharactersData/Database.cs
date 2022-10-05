using Characters;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Xml.Linq;

namespace CharactersData
{
    static public class Database
    {
        public static void AddToDatabase(Character ch)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CharactersData");
            var collection = database.GetCollection<Character>("Characters");
            collection.InsertOne(ch);
        }

        public static List<string> OutputListNames()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CharactersData");
            var collection = database.GetCollection<Character>("Characters");
            List<string> names = new List<string>();

            List<Character> characters = collection.Find(x => x.Name != null).ToList<Character>();
            
            foreach (var ch in characters)
            {
                names.Add(ch.Name);
            }

            return names;
        }

        public static Character FindByName(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CharactersData");
            var collection = database.GetCollection<Character>("Characters");
            var character = collection.Find(x => x.Name == name).FirstOrDefault();

            switch(character.ClassName)
            {
                case "Warrior":
                    return new Warrior(character.Strength, 
                        character.Dexterity, character.Constitution, 
                        character.Inteligence, character.Name, 
                        character.NumberOfPoints, character.inventory,
                        character.CharacterAbilities, character.Abilities, 
                        character.Level, character.LevelPoints, 
                        character.NextLevelPoints, character.abilityCount);

                case "Rogue":
                    return new Rogue(character.Strength,
                       character.Dexterity, character.Constitution, 
                       character.Inteligence, character.Name, 
                       character.NumberOfPoints, character.inventory,
                       character.CharacterAbilities, character.Abilities,
                       character.Level, character.LevelPoints, 
                       character.NextLevelPoints, character.abilityCount);

                case "Wizard":
                    return new Wizard(character.Strength,
                       character.Dexterity, character.Constitution, 
                       character.Inteligence, character.Name, 
                       character.NumberOfPoints, character.inventory,
                       character.CharacterAbilities, character.Abilities,
                       character.Level, character.LevelPoints, 
                       character.NextLevelPoints, character.abilityCount);

                default:
                    return character;
            }
        }

        public static void ReplaceByName(string name, Character ch)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CharactersData");
            var collection = database.GetCollection<Character>("Characters");
            collection.ReplaceOne(x => x.Name == name, ch);
        }

        public static void AddItemToDatabase(Item item)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Items");
            var weapons = database.GetCollection<Item>("Weapons");
            var helmets = database.GetCollection<Item>("Helmets");
            var armors = database.GetCollection<Item>("Armors");

            switch(item.Type)
            {
                case "Weapon":
                    weapons.InsertOne(item);
                    break;

                case "Helmet":
                    helmets.InsertOne(item);
                    break;

                case "Armor":
                    armors.InsertOne(item);
                    break;

                default:
                    break;
            }
        }
    }
}