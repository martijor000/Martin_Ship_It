using System;
using System.Text.RegularExpressions;

namespace Martin_Ship_It
{
    class Program
    {
        static ConsoleKeyInfo userInput;
        static IShippable[] iship = new IShippable[4];
        static Shipper sp = new Shipper();

        private static void Main(string[] args)
        {
            OptionsMenu();
        }
        private static void OptionsMenu()
        {

            do
            {
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the Shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add Crackers to the shipment");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6. Compute Shipping Charges");

                userInput = Console.ReadKey();
                Console.WriteLine("");
                Console.Clear();
                ValidateInput(userInput);

            } while (userInput.Key != ConsoleKey.D6);

            Console.WriteLine("Total shipping cost for this order is " + sp.TotalCost().ToString("C") + ".");
            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
            Console.Clear();
        }
        private static void ValidateInput(ConsoleKeyInfo testInput)
        {
            //Regex to verify if the key is 1-6. if not it will run the bad input method.
            if (!Regex.Match(testInput.Key.ToString(), ".*[1-6].*").Success)
            {
                BadInput();
            }
            else if (testInput.Key == ConsoleKey.D1)
            {
                iship[0] = new Bicycles();
                Console.WriteLine(sp.Add(iship[0]));
                PressKey();
            }
            else if (testInput.Key == ConsoleKey.D2)
            {
                iship[1] = new Lawn_Mowers();
                Console.WriteLine(sp.Add(iship[1]));
                PressKey();
            }
            else if (testInput.Key == ConsoleKey.D3)
            {
                iship[2] = new Baseball_Gloves();
                Console.WriteLine(sp.Add(iship[2]));
                PressKey();
            }
            else if (testInput.Key == ConsoleKey.D4)
            {
                iship[3] = new Crackers();
                Console.WriteLine(sp.Add(iship[3]));
                PressKey();
            }
            else if (testInput.Key == ConsoleKey.D5)
            {
                sp.List();
            }

        }
        private static void BadInput()
        {
            Console.WriteLine("Bad input please enter one of the following digits.");
            OptionsMenu();
            ConsoleKeyInfo newKey = Console.ReadKey();
            userInput = newKey;
        }
        private static void PressKey()
        {
            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}