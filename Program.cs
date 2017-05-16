using System;
using System.Collections.Generic;


namespace massRaise
{
    class Program
    {
        static void Main()
        {
            Dictionary < string, int > dict = new Dictionary < string, int > ();
            dict.Add("Neil", 1000);
            dict.Add("Sarah", 2000);
            dict.Add("Kumar", 3000);
            dict.Add("Mala", 4000);


            foreach (KeyValuePair <string, int> pair in dict)
            {
                Console.WriteLine("Name: {0}", pair.Key);
                Console.WriteLine("New salary: {0}", pair.Value + pair.Value/10);
                Console.WriteLine("Your got a raise of {0}!", pair.Value/10);
            }
        }
    }
}

