using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Capstone.VendingMachine
{
     public class Inventory
    {
        public void StockMachine(Dictionary<string, VendingMachineProduct> inventory)
        {
            using (StreamReader sr = new StreamReader("VendingMachine.csv"))
            {
                while (!sr.EndOfStream)
                {
                    //string[] currentItem = sr.ReadLine().Split('|');
                    //string type = currentItem[currentItem.Length - 1];
                    //VendingMachineProduct vendingMachineProduct;
                    //if (type == "Chip")
                    //{
                    //    vendingMachineProduct = new Chip(currentItem[1], decimal.Parse(currentItem[2]));
                    //    inventory.Add(currentItem[0], vendingMachineProduct);
                    //}
                    //else if (type == "Drink")
                    //{
                    //    vendingMachineProduct = new Drink(currentItem[1], decimal.Parse(currentItem[2]));
                    //    inventory.Add(currentItem[0], vendingMachineProduct);
                    //}
                    //else if (type == "Candy")
                    //{
                    //    vendingMachineProduct = new Candy(currentItem[1], decimal.Parse(currentItem[2]));
                    //     inventory.Add(currentItem[0], vendingMachineProduct);
                    //}
                    //else if (type == "Gum")
                    //{
                    //     vendingMachineProduct = new Gum(currentItem[1], decimal.Parse(currentItem[2]));
                    //     inventory.Add(currentItem[0], vendingMachineProduct);
                    //}
                    //inventory.Add(currentItem[0], vendingMachineProduct);


                    string currentLine = sr.ReadLine();
                    string[] itemInfo = currentLine.Split('|');

                    VendingMachineProduct vendingMachineProduct = Assembly.GetExecutingAssembly().CreateInstance("Capstone.VendingMachine." + itemInfo[itemInfo.Length - 1], true, BindingFlags.Default, null, new string[]{ itemInfo[1], itemInfo[2] }, null, null ) as VendingMachineProduct;
                    inventory.Add(itemInfo[0], vendingMachineProduct);
                }
            }
        }
    }
}
