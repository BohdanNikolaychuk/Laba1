using System;

namespace ConsoleApp1
{
    public class Program
    {
        static public int Example(int n)
        {
            int m = n / 60;
            Console.WriteLine(m.ToString() + " секунд");
            return m;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть перше число");
            string S1 = Console.ReadLine();
            int n = int.Parse(S1);
            Example(n);
            Console.ReadLine();
             
        }
    }

}
