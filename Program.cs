using System;

namespace Chroming_Guide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of sockets on item: ");
            int sockets = Int32.Parse(Console.ReadLine());

            Console.Write("\r\n\r\nInt on the item: ");
            int i = Int32.Parse(Console.ReadLine());

            Console.Write("\r\nStr on the item: ");
            int s = Int32.Parse(Console.ReadLine());

            Console.Write("\r\nDex on the item: ");
            int d = Int32.Parse(Console.ReadLine());

            Item item = new Item(sockets, d, s, i);

            Console.Clear();

            Console.Write("Enter desired number of blue sockets: ");
            int b = Int32.Parse(Console.ReadLine());
            
            Console.Write("\r\nEnter desired number of green sockets: ");
            int g = Int32.Parse(Console.ReadLine());
            
            Console.Write("\r\nEnter desired number of red sockets: ");
            int r = Int32.Parse(Console.ReadLine());

            item.SetDesiredColors(g, b, r);

            Console.Clear();

            Console.WriteLine(string.Format("Chance of getting {0} blue, {1} green, and {2} red sockets: {3}.", item.DesiredBlue, item.DesiredGreen, item.DesiredRed, item.Chance));
            Console.WriteLine("\r\nExpected number of chromatics for 95% success: " + item.GetNumberOfChroms());
            Console.Write("\r\n\r\n\r\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
