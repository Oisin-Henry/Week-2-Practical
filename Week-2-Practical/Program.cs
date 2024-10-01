using System;

public class Program
{
    public static void Main(string[] args)
    {

        PrintMenu();

        void PrintMenu()
        {

            try
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid option from below:");
                Console.WriteLine("1. Hello in French?");
                Console.WriteLine("2. Hello in Spanish?");
                Console.WriteLine("3. Hello in German?");
                Console.WriteLine("4. Hello in Italian?");
                Console.WriteLine("0. Exit application");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HelloFrench();
                        break;
                    case "2":
                        HelloSpanish();
                        break;
                    case "3":
                        HelloGerman();
                        break;
                    case "4":
                        HelloItalian();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error. {ex.Message}");
            }
        }

        static void HelloFrench()
        {
            Console.WriteLine("Bonjour");
        }
        static void HelloSpanish()
        {
            Console.WriteLine("Hola");
        }
        static void HelloGerman()
        {
            Console.WriteLine("Hallo");
        }
        static void HelloItalian()
        {
            Console.WriteLine("Ciao");
        }
    }
}