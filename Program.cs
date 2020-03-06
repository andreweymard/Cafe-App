using System;

namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to our Cafe.\nPlease enter Customer's Name: ");
            string Name = Console.ReadLine();
            Console.Write("Please enter Customer's Email Address: ");
            string EmailAddress = Console.ReadLine();
            Console.Write("Please enter Customer's Telephone Number (Please enter only digits): ");
            string TeleNumber = Console.ReadLine();

            var customer = new CafeExternal.Customer(Name, EmailAddress, TeleNumber);

            Console.Clear();

            var menu = new CafeInternal.Menu();
            Console.WriteLine("Hi " + customer.Name + ",");
            menu.Items();

            var bill = new CafeInternal.Bill();

            string exit = "";
            while (exit != "N")
            {
                Console.WriteLine("\nPlease enter the item code of the item you want.\n(One item code at a time)");
                string Code = Console.ReadLine().ToUpper();
                
                Console.WriteLine("Please enter the amount of the above item you want.\n(Use numbers)");
                byte Amount = Convert.ToByte(Console.ReadLine());

                bill.Items(Code, Amount);

                Console.WriteLine("\nDo you want to add another item?\n(Press enter if yes, N if no)");
                exit = Console.ReadLine().ToUpper();
            }

            Console.Clear();

            bill.GenBill();

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
