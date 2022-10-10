using System;
using System.Collections.Generic;
using System.Linq;

namespace Martin_Ship_It
{
    class Shipper
    {
        private List<IShippable> productList = new List<IShippable>();
        private Dictionary<string, int> dict = new Dictionary<string, int>();
        private decimal totalCost;
        
        public string Add(IShippable obj)
        {
            productList.Add(obj);
            return "1 " + obj.Product + " has been added.";
        }
        
        public void List()
        {
            ComputeList();
        }
        
        private void ComputeList()
        {
            dict = productList.GroupBy(item => item.Product).ToDictionary(item => item.Key, item => item.Count());
            
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                if (kvp.Key == "Crackers")
                {
                    Console.WriteLine(kvp.Value + " " + kvp.Key);
                }
                else if(kvp.Value > 1)
                {
                    Console.WriteLine(kvp.Value + " " + kvp.Key + "s");
                }
                else
                {
                    Console.WriteLine(kvp.Value + " " + kvp.Key);
                }
            }
        }
        
        public decimal TotalCost()
        {
            return ComputeCost();
        }
        
        private decimal ComputeCost()
        {
            for (int i = 0; i < productList.Count; i++){
                totalCost += productList[i].ShipCost;
            }
            return totalCost;
        }
    }
}
