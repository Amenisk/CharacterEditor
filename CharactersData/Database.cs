using Core;
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

        public static List<String> GetNameEquipment(Character character, string type)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Items");
            var filter = Builders<Item>.Filter.Where
                (x => x.LvlItem <= character.Level 
                && (x.ItemClass == character.ClassName || x.ItemClass == "All"));
            var items = new List<Item>();
            var nameList = new List<string>();

            switch (type)
            {
                case "Weapon":
                    var weapons = database.GetCollection<Item>("Weapons");
                    items = weapons.Find(filter).ToList();
                    break;

                case "Helmet":
                    var helmets = database.GetCollection<Item>("Helmets");
                    items = helmets.Find(filter).ToList();
                    break;

                case "Armor":
                    var armors = database.GetCollection<Item>("Armors");
                    items = armors.Find(filter).ToList();
                    break;
            }

            foreach(var item in items)
            {
                nameList.Add(item.Name);
            }

            return nameList;
        }
        public static Item FindItemByName(string name, string type)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Items");
            var item = new Item();

            switch (type)
            {
                case "Weapon":
                    var weapons = database.GetCollection<Item>("Weapons");
                    item = weapons.Find(x => x.Name == name).FirstOrDefault();
                    break;

                case "Helmet":
                    var helmets = database.GetCollection<Item>("Helmets");
                    item = helmets.Find(x => x.Name == name).FirstOrDefault();
                    break;

                case "Armor":
                    var armors = database.GetCollection<Item>("Armors");
                    item = armors.Find(x => x.Name == name).FirstOrDefault();
                    break;

                default:
                    break;
            }

            return item;
        }
        public static void UpdateInventory(string nameChar, List<Item> items)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("CharactersData");
            var collection = database.GetCollection<Character>("Characters");
            var updateDefinition = Builders<Character>.Update.Set("inventory", items);

            collection.UpdateOne(x => x.Name == nameChar, updateDefinition);
        }
    }
}