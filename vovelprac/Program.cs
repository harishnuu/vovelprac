using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace vovelprac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a caracter");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'I' || ch == 'i' ||
            ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
            {
                Console.WriteLine("{0} is a vowel !", ch);
            }
            else
            {
                Console.WriteLine("{0} IS NOT A VOWEL !", ch);
            }
            Console.ReadLine();
        }
    }
}