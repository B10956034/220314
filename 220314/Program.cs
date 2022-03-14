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
                for (int j = 1; j < 10; j++)
                {
                    int k = i * j;
                    Console.Write(i + "*" + j + "=" + k + " ");
                }
                Console.WriteLine();
            }



            int[] data = { 80, 75, 60, 65, 67, 62, 100, 93, 91, 98, 25, 50, 83, 82, 87 };
            Console.WriteLine("輸入座號(1-5)");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input >= 1 && input <= 5)
            {
                if (input == 1)
                {
                    Console.WriteLine("1.姓名：Jack");
                    Console.WriteLine("2.電腦概論：" + data[0]);
                    Console.WriteLine("3.程式設計：" + data[1]);
                    Console.WriteLine("4.動畫設計：" + data[2]);
                }
                else if (input == 2)
                {
                    Console.WriteLine("1.姓名：Mary");
                    Console.WriteLine("2.電腦概論：" + data[3]);
                    Console.WriteLine("3.程式設計：" + data[4]);
                    Console.WriteLine("4.動畫設計：" + data[5]);
                }
                else if (input == 3)
                {
                    Console.WriteLine("1.姓名：Tom");
                    Console.WriteLine("2.電腦概論：" + data[6]);
                    Console.WriteLine("3.程式設計：" + data[7]);
                    Console.WriteLine("4.動畫設計：" + data[8]);
                }
                else if (input == 4)
                {
                    Console.WriteLine("1.姓名：Grace");
                    Console.WriteLine("2.電腦概論：" + data[9]);
                    Console.WriteLine("3.程式設計：" + data[10]);
                    Console.WriteLine("4.動畫設計：" + data[11]);
                }
                if (input == 5)
                {
                    Console.WriteLine("1.姓名：Alice");
                    Console.WriteLine("2.電腦概論：" + data[12]);
                    Console.WriteLine("3.程式設計：" + data[13]);
                    Console.WriteLine("4.動畫設計：" + data[14]);
                }
            }
            else
            {
                Console.WriteLine("座號超出範圍");
            }




            //快的做法
            int[] No = { 1, 2, 3, 4, 5 };
            string[] name = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] scoreA = { 80, 65, 100, 98, 83 };
            int[] scoreB = { 75, 67, 93, 25, 82 };
            int[] scoreC = { 60, 62, 91, 50, 87 };

            while (true)
            {
                Console.WriteLine("輸入座號(1-5)");
                var newNo = Console.ReadLine();
                int newInput = int.Parse(newNo);
                int arrayIndex = Array.IndexOf(No,newInput);
                if(arrayIndex > -1)
                {
                    Console.WriteLine("姓名：" + name[arrayIndex]);
                    Console.WriteLine("電腦概論：" + scoreA[arrayIndex]);
                    Console.WriteLine("程式設計：" + scoreB[arrayIndex]);
                    Console.WriteLine("動畫設計：" + scoreC[arrayIndex]);
                }
                else
                {
                    Console.WriteLine("座號超出範圍");
                }
            }









        }
    }
}
