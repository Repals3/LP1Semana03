using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("String: ");
            string readString= Console.ReadLine();
            Console.WriteLine("Caráter: ");
            string readCaracter= Console.ReadLine();

            char Sub = char.Parse(readCaracter);

            foreach (char i in readString)
            {
                if ( i == Sub)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(i);
                }
            }
        }
    }
}