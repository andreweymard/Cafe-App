using System;
using System.Collections.Generic;

namespace Assignment.CafeInternal
{
    public class Bill
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public byte Amount { get; set; }
        public double Total { get; set; }
        public double FinalTotal { get; set; }
        const double TaxValue = 0.10;
        const double ServiceCharge = 0.05;
        const double GrandTotal = 1 + ServiceCharge + TaxValue;

        List<Bill> Content = new List<Bill>();

        public void Items(string Code, byte Amount)
        {
            Menu menus = new Menu();

            for (int i = 0; i < menus.AddMenu().Count; i++)
            {
                Menu m = menus.AddMenu()[i];
                if (Code == m.Code && Amount > 0)
                {
                    Console.WriteLine("You have Chosen " + Amount + " " + m.Name + ".");
                    Content.Add(new Bill { Name = m.Name, Amount = Amount, Price = m.Price });
                }
            }
        }

        public override string ToString()
        {
            Total = Amount * Price;
            return String.Format("{0,20}   |{1,10}   |{2,10}", Name, Amount, Total);
        }

        public void GenBill()
        {
            Console.WriteLine("This is your bill.\n\n{0,20}   |{1,10}   |{2,10}", "Item", "Amount", "Total");
            Console.WriteLine("   ---------------------------------------------------");

            foreach (Bill abill in Content)
            {
                Console.WriteLine(abill);
            }

            for (int x = 0; x < Content.Count; x++)
            {
                Bill con = Content[x];
                FinalTotal += con.Total;
            }

            Console.WriteLine("\nTotal Cost:           " + FinalTotal + "\nTotal Tax:            " + FinalTotal * TaxValue);
            Console.WriteLine("Total Service Charge: " + FinalTotal * ServiceCharge + "\nGrand Total:          " + FinalTotal * GrandTotal);

            Console.WriteLine("\nThank You, Come Again.    :)\n");
        }
    }
}
