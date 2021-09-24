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

            // Get all averages
            double classA = data[0].CalculateAverage();
            double classB = data[1].CalculateAverage();
            double classC = data[2].CalculateAverage();
            double classD = data[3].CalculateAverage();

            // Create lists of averages
            List<double> averages = new List<double> {classA, classB, classC, classD};
            List<double> averagesSorted = new List<double> {classA, classB, classC, classD};
            averagesSorted.Sort();

            for (int i = 0; i < data.Count; i++)
            {
                // Combine the ranks to print as a list
                var ranks = String.Join(", ", data[i].Ranks);
                
                // Find the place of this group
                double place = averagesSorted.IndexOf(averages[i]);

                // Print group and its place
                Console.WriteLine($"{data[i].Name} - Place #{place + 1} - [{ranks}]");
            }
        }
    }
}