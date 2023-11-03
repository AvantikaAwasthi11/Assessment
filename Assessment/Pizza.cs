using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Pizza
    {
        private string size;
        private int cheeseToppings;
        private int pepperoniToppings;
        private int hamToppings;

        public string Size
        {
            get 
            { 
                return size;
            }
            set 
            { 
                size = value;
            }
        }

        public int CheeseToppings
        {
            get
            { 
                return cheeseToppings; 
            }
            set 
            { 
                cheeseToppings = value;
            }
        }

        public int PepperoniToppings
        {
            get 
            { 
                return pepperoniToppings;
            }
            set
            { 
                pepperoniToppings = value;
            }
        }

        public int HamToppings
        {
            get
            { 
                return hamToppings;
            }
            set
            { 
                hamToppings = value;
            }
        }

        public Pizza(string size, int cheeseToppings, int pepperoniToppings, int hamToppings)
        {
            this.size = size;
            this.cheeseToppings = cheeseToppings;
            this.pepperoniToppings = pepperoniToppings;
            this.hamToppings = hamToppings;
        }

        public double CalcCost()
        {
            double cost = 0;

            switch (size)
            {
                case "Small":
                    cost = 10 + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
                    break;
                case "Medium":
                    cost = 12 + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
                    break;
                case "Large":
                    cost = 14 + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
                    break;
                default:
                    Console.WriteLine("INVALID SIZE");
                    break;
            }

            return cost;
        }

        public string GetDescription()
        {
            return $"{size} Pizza with {cheeseToppings} Cheese Toppings, {pepperoniToppings} Pepperoni Toppings, and {hamToppings} Ham Toppings.";
        }
    }
}
