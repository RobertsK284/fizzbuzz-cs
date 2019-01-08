using System;

namespace fizzbuzz_csharp
{
    public class Fizzbuzz
    {
        public string Play(int number)
        {

            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }


        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 100;
            Fizzbuzz n = new Fizzbuzz();

            for (int i = a; i < b + 1; i = i + 1)
            {
                Console.WriteLine(n.Play(i));
            }
        }
    }
}
