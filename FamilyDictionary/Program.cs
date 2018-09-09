using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myPeeps = new Dictionary<string, Dictionary<string, string>>();

            myPeeps.Add("madre", new Dictionary<string, string> {
                { "name", "MommaFox" },
                { "age", "42" }
            });
            myPeeps.Add("padre", new Dictionary<string, string> {
                { "name", "FoxyPop" },
                { "age", "42" }
            });
            myPeeps.Add("brosef", new Dictionary<string, string> {
                { "name", "PolloDiablo" },
                { "age", "42" }
                });
            

            foreach (var i in myPeeps)
            {
                Console.WriteLine($"{i.Value["name"]} is my {i.Key} and is {i.Value["age"]} years young.");
            }

            Console.ReadLine();
        }
    }
}
