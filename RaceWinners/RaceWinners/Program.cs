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
            /*
            * TO DO:
            * - decide winners
            * - print it all out nicely
            */
            
            DataService ds = new DataService();
 
            // Asynchronously retrieve the group (class) data
            var data = await ds.GetGroupRanksAsync();

            double classA = data[0].CalculateAverage();
            double classB = data[1].CalculateAverage();
            double classC = data[2].CalculateAverage();
            double classD = data[3].CalculateAverage();
            
            

            for (int i = 0; i < data.Count; i++)
            {
                // Combine the ranks to print as a list
                var ranks = String.Join(", ", data[i].Ranks);
                
                Console.WriteLine($"{data[i].Name} - [{ranks}]");
            }

            //Console.WriteLine(g.CalculateAverage());
        }
    }
}