using Assessment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class AssessmentProgram
    {
        static void Main()
        {
            List<Pizza> pizzaOrders = new List<Pizza>();
            Pizza pizza1 = new Pizza("Medium", 1, 2, 0);
            Pizza pizza2 = new Pizza("Large", 2, 1, 3);
            Pizza pizza3 = new Pizza("Medium", 4, 1, 3);
            Pizza pizza4 = new Pizza("Large", 2, 4, 3);
            Pizza pizza5 = new Pizza("Small", 2, 1, 1);
            pizzaOrders.Add(pizza1);
            pizzaOrders.Add(pizza2);
            pizzaOrders.Add(pizza3);
            pizzaOrders.Add(pizza4);
            pizzaOrders.Add(pizza5);

            /*
            int Number;
            Number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter number of Pizzas");
            for(int i = 0;i< Number; i++) {
                pizzaOrders.Add(pizzaOrders[i]);
            }
            */

            foreach (Pizza pizza in pizzaOrders)
            {
                Console.WriteLine(pizza.GetDescription());
                Console.WriteLine("TotalCost: $" + pizza.CalcCost());
                Console.WriteLine();
            }
        }
    }
}