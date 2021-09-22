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

            List<double> averages = new List<double> {classA, classB, classC, classD};
            List<double> averagesSorted = new List<double> {classA, classB, classC, classD};
            averagesSorted.Sort();

            /*
            foreach (double average in averages)
            {
                Console.WriteLine(average);
            }
            */
            
            for (int i = 0; i < data.Count; i++)
            {
                // Combine the ranks to print as a list
                var ranks = String.Join(", ", data[i].Ranks);
                double place = averagesSorted.IndexOf(averages[i]);

                Console.WriteLine($"{data[i].Name} - [{ranks}]");
            }

            //Console.WriteLine(g.CalculateAverage());
        }
    }
}