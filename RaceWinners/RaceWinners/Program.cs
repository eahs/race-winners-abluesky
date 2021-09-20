using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RaceWinners.Models;

namespace RaceWinners
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DataService ds = new DataService();
 
            // Asynchronously retrieve the group (class) data
            var data = await ds.GetGroupRanksAsync();

            

            for (int i = 0; i < data.Count; i++)
            {
                // Combine the ranks to print as a list
                var ranks = String.Join(", ", data[i].Ranks);
                
                Console.WriteLine($"{data[i].Name} - [{ranks}]");
            }
            
            Console.WriteLine(data[0].CalculateAverage());
        }
    }
}