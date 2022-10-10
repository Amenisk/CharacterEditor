using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace Core
{
    public class Match
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public DateTime date { get; private set; }
        public List<Character> FirstTeam { get; private set; } = new List<Character>();
        public List<Character> SecondTeam { get; private set; } = new List<Character>();

        public void AddCharacterToTeam(Character ch, int team)
        {
            if(team == 1) FirstTeam.Add(ch);
            else if (team == 2) SecondTeam.Add(ch);
        }

        
    }
}
