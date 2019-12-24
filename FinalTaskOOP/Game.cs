using System;
using System.Collections.Generic;
using System.Text;

namespace FinalTaskOOP
{
    class Game
    {
        public Team FirstTeam;
        public Team SecondTeam;
        public Refery ReferyName;

        public int counterFirstTeamGoals = 0;
        public int counterSecondTeamGoals = 0;

        public delegate void Action(FootballPlayer fp);
        public event Action Goal;
        public event Action Violation;
        public Game(Team t1, Team t2, Refery refery)
        {
            FirstTeam = t1;
            SecondTeam = t2;
            ReferyName = refery;
        }
        public void Winner() //calculating results of the game
        {
            if(Math.Abs(FirstTeam.MasterSum - SecondTeam.MasterSum) > 0.1 * SecondTeam.MasterSum) 
            {
                string winner = FirstTeam.MasterSum > SecondTeam.MasterSum ? FirstTeam.Name : SecondTeam.Name;
                Console.WriteLine($"{winner} is the winner!");
            }
                
            else if (ReferyName.Honest != (HonestRefery)1) 
            {
                string badWinner = ReferyName.Honest == (HonestRefery)2 ? FirstTeam.Name : SecondTeam.Name;
                Console.WriteLine($"{badWinner} is the winner!");
            }
            else
                Console.WriteLine("Friendship is everything!");
        }

        public void Start()
        {
            try
            {
                if (Randomizer.rnd.Next(1, 5) == 1)
                    throw new SomethingWrongHappened("OH NO, IT IS FUCKING TORNADO!!!"); 

                Console.WriteLine("Game starts!");

                Goal?.Invoke(FirstTeam.Players[1]);
                counterFirstTeamGoals += 1;

                Violation?.Invoke(SecondTeam.Players[0]);
                counterSecondTeamGoals -= 1;

                ConvertingCountersToTotalScore();
                Winner();
            }
            catch(SomethingWrongHappened ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Sorry, the game can`t be started. Let`s try again next life.");
            }
        }

        public void ConvertingCountersToTotalScore()
        {
            double resFirstTeam = FirstTeam.MasterSum + counterFirstTeamGoals * 100;
            double resSecondTeam = SecondTeam.MasterSum + counterSecondTeamGoals * 100;

            Console.WriteLine($"{FirstTeam.Name} get {resFirstTeam} points.");
            Console.WriteLine($"{SecondTeam.Name} get {resSecondTeam} points.");
        }

    }
}
