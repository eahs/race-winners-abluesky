using System.Collections.Generic;
using System.Linq;

namespace RaceWinners.Models
{
    /// <summary>
    /// Stores all the data associated with a group of runners
    /// </summary>
    public class Group
    {
        // Name of group
        public string Name { get; set; }
        
        /// <summary>
        /// Each spot in the list represents the overall rank of finish place in this group
        /// (not the overall race).  So if index 0 contains a 4, then the first runner in this
        /// group placed 4th overall.  
        /// </summary>
        public List<int> Ranks { get; set; }

        // Calculate and return the weighted average
        public double CalculateAverage()
        {
            List<int> newRanks = new List<int>();

            foreach (int rank in Ranks)
            {
                if (rank < 3)
                {
                    AddRanks(newRanks, rank, 4);
                }
                else if (rank is > 3 and < 16)
                {
                    AddRanks(newRanks, rank, 3);
                }
                else if (rank is > 15 and < 31)
                {
                    AddRanks(newRanks, rank, 2);
                }
                else
                {
                    AddRanks(newRanks, rank, 1);
                }
            }

            return newRanks.Average();
        }

        // Adds a rank a certain number of times
        private static void AddRanks(List<int> newRanks, int rank, int count)
        {
            for (int i = 0; i < count; i++)
            {
                newRanks.Add(rank);
            }
        }
    }
}