using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public class Change
    {
        private readonly int[] coinValues = { 25, 10, 5 };

        public int Quarters {get;private set;}
        public int Dimes { get; private set; }
        public int Nickels { get; private set; }

        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickels = 0;
        }
        
        public void MakeChange(decimal balance)
        {
            int workingBalance = (int)balance * 100;
            for (int i=0;i<coinValues.Length;i++)
            {
                while ((workingBalance % coinValues[i]==0))
                {
                    workingBalance -= coinValues[i];
                    if(i==0)
                    {
                        Quarters++;
                    }
                    else if(i==1)
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
