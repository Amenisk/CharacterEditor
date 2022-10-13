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

        private double _maxBalanceDifference = 1.5;
        private int _maxCountCharacters = 6;

        public string Time { get; private set; }
        public List<CharacterInfo> FirstTeam { get; private set; } = new List<CharacterInfo>();
        public List<CharacterInfo> SecondTeam { get; private set; } = new List<CharacterInfo>();

        public void SaveTime()
        {
            Time = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
        }
        public void AddCharacterToTeam(CharacterInfo ch, int team)
        {
            if(team == 1) FirstTeam.Add(ch);
            else if (team == 2) SecondTeam.Add(ch);
        }
        public void RemoveCharacterFromTeam(string name, int team)
        {
            if (team == 1)
            {
                foreach(var c in FirstTeam)
                {
                    if (name == c.Name)
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
                    if (name == c.Name)
                    {
                        SecondTeam.Remove(c);
                        break;
                    }
                }
            }
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

            return Math.Abs(lvls1 / _maxCountCharacters 
                - lvls2 / _maxCountCharacters) < _maxBalanceDifference
                && lvls1 != 0 && lvls2 != 0;
        }  
    }
}
