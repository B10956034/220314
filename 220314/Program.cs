using System;

namespace _220314
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine("輸入數字");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if(num >=2 && num <= 5)
            {
                Console.WriteLine("Not weird");
            }
            else if(num >=6 && num <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
            
        }
    }
}
