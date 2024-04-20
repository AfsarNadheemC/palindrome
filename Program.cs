using System.Numerics;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assalamu Alaikkum");
            Console.WriteLine("Enter a Name to check Palindrome");
            string a = Console.ReadLine();
            if(Palindrome.Pali(a)){
                Console.WriteLine("Yes, It's a Palindrome");
            }
            else
            {
                Console.WriteLine("No, It's not a Palindrome");
            }

        }


    }
}