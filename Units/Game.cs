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
    public class Game
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
        public void RemoveCharacterFromTeam(Character ch, int team)
        {
            if (team == 1)
            {
                foreach(var c in FirstTeam)
                {
                    if (ch.Name == c.Name)
                    {
                        FirstTeam.Remove(c);
                        break;
                    } 
                }
            }
            else if (team == 2)
            {
                foreach (var c in SecondTeam)
                {
                    if (ch.Name == c.Name)
                    {
                        SecondTeam.Remove(c);
                        break;
                    }
                }
            }
        }

        public void ClearTeams()
        {
            FirstTeam.Clear();
            SecondTeam.Clear();
        }
        public bool IsBalansed()
        {
            int lvls1 = 0;
            int lvls2 = 0;

            foreach(var ch in FirstTeam)
            {
                lvls1 += ch.Level;
            }

            foreach (var ch in SecondTeam)
            {
                lvls2 += ch.Level;
            }

            return Math.Abs(lvls1 - lvls2) < 2;
        }



        
    }
}
