using System;

namespace RubleIsEmptySpace
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("$".CompareTo("") == 1); //true
            Console.WriteLine("₽".CompareTo("") == 0); //true
        }
    }
}
