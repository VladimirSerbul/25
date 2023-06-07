using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int n=0;
            try
            {
                Console.WriteLine("введите размерность массива ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                    throw new Exception("некорреткно введены данные");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                p();
                return;
            }
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,5}", i);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-6, 7);
                Console.Write("{0,5}", array[i]);
            }

            int k, m = 0;
            for (int i = 0; i < n; i++)
            {
                bool flag = true;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[i] == array[j])
                        flag = false;
                }
                if (flag)
                {
                    m++;
                }
            }
            int[,] array1 = new int[m, 3];
            int a = 0, b = 0;
            for (int i = 0; i < n; i++)
            {
                k = 0;
                bool flag = true;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[i] == array[j])
                        flag = false;
                }
                if (flag)
                {
                    for (int m1 = i; m1 < n; m1++)
                    {
                        if (array[i] == array[m1])
                        {
                            k++;
                            b = m1;
                        }
                    }
                    if (array[i] < 0) array1[a, 2] = i;
                    else if (array[i] >= 0) array1[a, 2] = b;
                    array1[a, 0] = array[i];
                    array1[a, 1] = k;
                    a++;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,4}", array1[i, j]);
                }
                Console.WriteLine();
            }
            void p()
            {
                Console.WriteLine("повторить ввод если да то 1 нет то 0");
                string y = Convert.ToString(Console.ReadLine());
                if (y == "1")
                    Main();
                else
                    return;
            }
            p();
            return;
        }
    }
}
