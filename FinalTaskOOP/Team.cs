using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FinalTaskOOP
{
    class Team
    {
        public string Name;
        public List<FootballPlayer> Players = new List<FootballPlayer>(7);
        public double MasterSum = 0;
        public Couch CouchName;

        public void Recount()
        {
            MasterSum *= CouchName.Success;
        }
        public void Add(FootballPlayer fp)  //adding new player
        {
            MasterSum /= CouchName.Success;
            Players.Add(fp);
            Console.WriteLine($"{fp.Surname} was added to {Name} with level {fp.Master}");
            MasterSum += fp.Master;
            Recount();
        }

        
        public Team(string name, Couch couch)
        {
            this.Name = name;
            this.CouchName = couch;
        }

        public void Display() // all info about the team
        {
            Console.WriteLine($"Name: {Name}.  Master: {MasterSum}.  Couch: {CouchName.Surname} with success {CouchName.Success}");
            PlayersListDisplay();
            Program.Space();
            OldButGoldPlayersDisplay();
        }

        public void PlayersListDisplay() // players` surname list
        {
            var result = from p in Players orderby p.Surname select p.Surname;
            foreach (string s in result)
                Console.WriteLine(s);
        }

        public void OldButGoldPlayersDisplay() // players older 30
        {
            var result = from p in Players where p.Age >= 30 orderby p.Master descending select p.Surname;
            foreach (string s in result)
                Console.WriteLine(s);
        }
    }
}
