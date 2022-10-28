using System;

namespace practice1
{
    class Program
    {
        //Задание 1
        void task1(int x)
        {
            int[] arr = new int[x];

            for (int i = 0; i < x; i++)
            {
                Random rnd = new Random();
                arr[i] = rnd.Next(0, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int i = x - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }

        //Задание 2
        void task2(int h, int w)
        {
            int[,] A = new int[h, w];

            for (int i = 0; i < h - 1; i++)
                for (int j = i; j < w - 1; j++)
                    A[i, j] = 1;

            for (int i = 1; i < h - 1; i++)
                for (int j = i - 1; j < w - 1; j++)
                    A[i, j] = 1;

            for (int z = 0; z < w - 1; z++)
            {
                for (int g = 0; g < h - 1; g++)
                {
                    Console.Write(A[z, g] + " ");
                }
                Console.Write("\n");
            }
        }

        //Задания 3 и 4
        void task34(int a, int b)
        {
            int[,] array = new int[a, b];

            var SizeX = array.GetUpperBound(0);
            var SizeY = array.GetUpperBound(1);
            var maxX = SizeX + 1;
            var maxY = SizeY;
            var dirX = 1;
            var dirY = 1;

            var x = -1;
            var y = 0;
            var val = 1;
            while ((maxX >= 0) && (maxY >= 0))
            {
                for (int xval = 1; xval <= maxX; xval++)
                {
                    array[x + dirX * xval, y] = val;
                    val++;
                }

                x = x + dirX * maxX;
                dirX = -dirX;
                maxX--;

                for (int yval = 1; yval <= maxY; yval++)
                {
                    array[x, y + dirY * yval] = val;
                    val++;
                }

                y = y + dirY * maxY;
                dirY = -dirY;
                maxY--;
            }

            for (int i = 0; i <= array.GetUpperBound(1); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(0); j++)
                    Console.Write("\t" + array[j, i]);
                Console.WriteLine();
            }
        }

        //Задание с перечислимыми типами
        enum Op
        {
            sum,
            minus,
            multi,
            div
        }

        double doOperation(Op op, int a, int b)
        {
            return op switch
            {
                Op.sum => a + b,
                Op.minus => a - b,
                Op.multi => a * b,
                Op.div => a / b
            };
        }



        static void Main(string[] args)
        {
            Program p = new Program();
            p.task1(7);

            Console.WriteLine();
            Console.WriteLine();

            p.task2(7, 7);

            Console.WriteLine();

            p.task34(5, 7);

            Console.WriteLine();

            Console.WriteLine(p.doOperation(Op.multi, 3, 6));
        }
    }
}