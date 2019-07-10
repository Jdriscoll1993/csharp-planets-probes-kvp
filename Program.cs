using System;
using System.Collections.Generic;

namespace planets_and_probes_and_kvps
{
    class Program
    {
        static void Main(string[] args)
        {
            // could be var planetList =
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto" };

            // could be var probeDestinations =
            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>()
            {
            new KeyValuePair<string, string>("Viking 1", "Mars"),

            new KeyValuePair<string, string>("Mariner 1", "Venus"),

            new KeyValuePair<string, string>("Voyager 1", "Jupiter"),

            new KeyValuePair<string, string>("Voyager 1", "Saturn"),
            };


            //  Iterate over probeDestinations, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which probes have visited it.

            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> probe in probeDestinations)
                {
                    if (probe.Value == planet)
                    {
                        matchingProbes.Add(probe.Key);
                    }
                }
                Console.WriteLine($"{planet}: {string.Join(",", matchingProbes)}");
            }
        }
    }
}
