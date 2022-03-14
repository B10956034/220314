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
            if (num % 2 == 0)
            {
                Console.WriteLine("是偶數");
            }
            else
            {
                Console.WriteLine("是奇數");
            }
        }
    }
}
