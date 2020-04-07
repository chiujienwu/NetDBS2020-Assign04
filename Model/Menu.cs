using System;
using System.Linq;

namespace TicketingClasses.Model
{
    public class Menu
    {
        public Menu()
        {
            Console.WriteLine("------- MENU --------");
            Console.WriteLine("(1) Read Defects File");
            Console.WriteLine("(2) Read Enhancement File");
            Console.WriteLine("(3) Read Task File");
            Console.WriteLine("==========================");
            Console.WriteLine("(4) Create Defects");
            Console.WriteLine("(5) Create Enhancement");
            Console.WriteLine("(6) Create Task");
            Console.WriteLine("==========================");
            Console.WriteLine("(7) Write Defects File");
            Console.WriteLine("(8) Write Enhancement File");
            Console.WriteLine("(9) Write Task File");
            Console.WriteLine("==========================");
            Console.WriteLine("(A) Search by Status");
            Console.WriteLine("(B) Search by Priority");
            Console.WriteLine("(C) Search by Submitter");
            Console.WriteLine("==========================");
            Console.WriteLine("(0) Exit program");
        }
        public char GetUserInput()
        {
            char selection;

            Console.Write("?");
            while (!IsValidInput(Console.ReadKey(true).KeyChar, out selection))
            {
                Console.WriteLine($"Invalid input: {selection}");
                Console.WriteLine();
                Console.WriteLine("Please enter a valid option.");
                Console.Write("?");
            }

            Console.WriteLine("You have selected {0}", selection);
            return selection;
        }

        private bool IsValidInput(char input, out char selection)
        {
            char[] validValues = { '1', '2', '3', '4','5', '6', '7', '8', '9', '0', 'a', 'A', 'b', 'B', 'c', 'C' };

            selection = Char.ToUpper(input);
            if (validValues.Contains(input))
            {
                return true;
            }

            return false;
        }
    }
}
