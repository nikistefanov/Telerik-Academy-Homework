using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTaskGarden
{
    class Program
    {
        static void Main(string[] args)
        {
            int tomato = int.Parse(Console.ReadLine());
            int tomatoArea = int.Parse(Console.ReadLine());
            int cucumber = int.Parse(Console.ReadLine());
            int cucumberArea = int.Parse(Console.ReadLine());
            int potato = int.Parse(Console.ReadLine());
            int potatoArea = int.Parse(Console.ReadLine());
            int carrot = int.Parse(Console.ReadLine());
            int carrotArea = int.Parse(Console.ReadLine());
            int cabbage = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beans = int.Parse(Console.ReadLine());

            int totalArea = 250;
            int usedArea = tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea;
            int beansArea = totalArea - usedArea;

            double tomatoCost = tomato * 0.5;
            double cucumberCost = cucumber * 0.4;
            double potatoCost = potato * 0.25;
            double carrotCost = carrot * 0.6;
            double cabbageCost = cabbage * 0.3;
            double beansCost = beans * 0.4;

            double totalCost = tomatoCost + cucumberCost + potatoCost + carrotCost + cabbageCost + beansCost;

            if (totalArea < usedArea)
            {
                Console.WriteLine("Total costs: {0:F2}", totalCost);
                Console.WriteLine("Insufficient area");
            }
            else if (totalArea == usedArea)
            {
                Console.WriteLine("Total costs: {0:F2}", totalCost);
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Total costs: {0:F2}", totalCost);
                Console.WriteLine("Beans area: {0}", beansArea);
            }

        }
    }
}
