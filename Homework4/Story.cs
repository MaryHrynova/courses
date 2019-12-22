using System;
using System.Collections.Generic;
using System.Text;

namespace Homework1
{
    public static class Story
    {
        public static void Start(string grandpaName, string grandmaName, string chikenName)
        {
            Console.WriteLine($"Жили-были {grandpaName} и {grandmaName} и была у них курочка {chikenName}.");
        }

        public static void MainHeroOfThisStory<T>(T character) where T : Character
        {
            Console.WriteLine($"{character.ToString()}");
        }

        public static void End()
        {
            Console.WriteLine("Вот и сказочке конец, кто не слушал - молодец.");
        }
    }


}
