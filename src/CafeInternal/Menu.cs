using System;
using System.Collections.Generic;

namespace Assignment.CafeInternal
{
    public class Menu
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return String.Format("{0,10}   |{1,20}   |{2,30}    |{3,10}", Code, Name, Description, Price);
        }

        public List<Menu> AddMenu()
        {
            var mi = new List<Menu>();

            mi.Add(new Menu { Code = "D01", Name = "Cheesecake", Description = "A multi layered dessert.", Price = 300.00 });
            mi.Add(new Menu { Code = "B01", Name = "Tea", Description = "A drink made from leaves.", Price = 100.00 });
            mi.Add(new Menu { Code = "B02", Name = "Coffee", Description = "A drink made from beans.", Price = 600.00 });
            mi.Add(new Menu { Code = "M01", Name = "Chicken Sandwich", Description = "A snack with chicken.", Price = 250.00 });

            return mi;
        }

        public void Items()
        {
            Console.WriteLine("This is our menu:\n\n{0,10}   |{1,20}   |{2,30}    |{3,10}", "Code", "Name", "Description", "Price");
            Console.WriteLine("     -------------------------------------------------------------------------------");

            Menu menus = new Menu();
            foreach (Menu amenu in menus.AddMenu())
            {
                Console.WriteLine(amenu);
            }
        }
    }
}
