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

        //public double Average;

        public double CalculateAverage()
        {
            List<int> newRanks = new List<int>();

            foreach (int rank in Ranks)
            {
                if (rank < 3)
                {
                    newRanks.Add(rank);
                    newRanks.Add(rank);
                    newRanks.Add(rank);
                    newRanks.Add(rank);
                }
                else if (rank is > 3 and < 16)
                {
                    newRanks.Add(rank);
                    newRanks.Add(rank);
                    newRanks.Add(rank);
                }
                else if (rank is > 15 and < 31)
                {
                    newRanks.Add(rank);
                    newRanks.Add(rank);
                }
                else
                {
                    newRanks.Add(rank);
                }
            }

            return newRanks.Average();
        }
        
        

        // 1-3 = 3, 4-10 = 2, rest = 1
        /*
         * 1, 3, 6, 30
         * 1, 1, 1, 3, 3, 3, 6, 6, 30
         * 
         */
    }
}