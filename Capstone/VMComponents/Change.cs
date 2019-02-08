using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VMComponents
{
    /// <summary>
    /// Represents a Change Class
    /// </summary>
    public class Change
    {
        /// <summary>
        /// The Value of each coin
        /// </summary>
        private readonly int[] coinValues = { 25, 10, 5 };

        /// <summary>
        /// Represents the number of Quarters
        /// </summary>
        public int Quarters { get; private set; }
        
        /// <summary>
        /// Represents the number of Dimes
        /// </summary>
        public int Dimes { get; private set; }

        /// <summary>
        /// Represents the number of Nickels
        /// </summary>
        public int Nickels { get; private set; }


        /// <summary>
        /// Creates a Change class
        /// </summary>
        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickels = 0;
        }

        /// <summary>
        /// Generates the quantity of each coin
        /// </summary>
        /// <param name="balance"></param>
        public void MakeChange(decimal balance)
        {
            int workingBalance = (int)balance * 100;
            for (int i = 0; i < coinValues.Length; i++)
            {
                while ((workingBalance % coinValues[i] == 0) && workingBalance > 0)
                {
                    workingBalance -= coinValues[i];
                    if (i == 0)
                    {
                        Quarters++;
                    }
                    else if (i == 1)
                    {
                        Dimes++;
                    }
                    else
                    {
                        Nickels++;
                    }
                }
            }
        }
    }
}
