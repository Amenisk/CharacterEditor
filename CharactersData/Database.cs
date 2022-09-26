using Characters;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Xml.Linq;

namespace CharactersData
{
    static public class Database
    {
        public static void AddToDataBase(Character ch)
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
                        character.Inteligence, character.Name, character.NumberOfPoints);

                case "Rogue":
                    return new Rogue(character.Strength,
                       character.Dexterity, character.Constitution, 
                       character.Inteligence, character.Name, character.NumberOfPoints);

                case "Wizard":
                    return new Wizard(character.Strength,
                       character.Dexterity, character.Constitution, 
                       character.Inteligence, character.Name, character.NumberOfPoints);

                default:
                    return character;
            }
        }
    }
}