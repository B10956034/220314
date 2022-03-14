using System;

namespace _220314
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //判斷
            Console.WriteLine("輸入數字");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if (num >= 2 && num <= 5)
            {
                Console.WriteLine("Not weird");
            }
            else if (num >= 6 && num <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }

            //加總
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            //練習1
            Console.WriteLine("輸入數字");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            //練習2
            Console.WriteLine("輸入數字");
            int O = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= O; i++)
            {
                int P = O * i;
                Console.WriteLine(O + "*" + i + "=" + P);
            }


            //練習3
            for (int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    int k = i * j;
                    Console.Write(i + "*" + j + "=" + k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
