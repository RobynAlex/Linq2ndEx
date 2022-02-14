using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Using Method Syntax, create a list of video games of your choice…
               Order the list of games by the length of the game’s names...
               Be sure to use the lambda expression in this exercise!
            */

            var gameList = new List<string>()
            {
                "Halo",
                "Assassin's Creed",
                "Super Mario Glaxy 2",
                "Overwatch",
                "Madden 17"
            };

           // var letterGameList = gameList.OrderBy(name => name.Length);

           // foreach(var gameName in letterGameList)
           // {
          //      Console.WriteLine(gameName);
           // }

            var letterGameList = gameList.Where(name => name.Contains("d"));

            foreach(var gameName in letterGameList)
            {
                Console.WriteLine(gameName);
            }

            
        }
    }
}
