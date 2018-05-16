using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };

            //foreach (int item in CountDigits(list))
            //{
            //    Console.WriteLine(item);
            //}
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            int counter7 = 0;
            int counter8 = 0;
            int counter9 = 0;
            int counter10 = 0;
            int counter0 = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == 0)
                {
                    counter0++;
                }
                else if (list[i] == 1)
                {
                    counter1++;
                }
                else if (list[i] == 2)
                {
                    counter2++;
                }
                else if (list[i] == 3)
                {
                    counter3++;
                }
                else if (list[i] == 4)
                {
                    counter4++;
                }
                else if (list[i] == 5)
                {
                    counter5++;
                }
                else if (list[i] == 6)
                {
                    counter6++;
                }
                else if (list[i] == 7)
                {
                    counter7++;
                }
                else if (list[i] == 8)
                {
                    counter8++;
                }
                else if (list[i] == 9)
                {
                    counter9++;
                }
                else if (list[i] == 10)
                {
                    counter10++;
                }
            }
            Console.WriteLine($"[0]: {counter0}");
            Console.WriteLine($"[1]: {counter1}");
            Console.WriteLine($"[2]: {counter2}");
            Console.WriteLine($"[3]: {counter3}");
            Console.WriteLine($"[4]: {counter4}");
            Console.WriteLine($"[5]: {counter5}");
            Console.WriteLine($"[6]: {counter6}");
            Console.WriteLine($"[7]: {counter7}");
            Console.WriteLine($"[8]: {counter8}");
            Console.WriteLine($"[9]: {counter9}");
            Console.WriteLine($"[10]: {counter10}");

        }

        static List<int> CountDigits(int[] x)
        {
            int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Array.Sort(x);
            int counter = 0;
            int clock = 0;

            List<int> vs = new List<int>();

            for (int i = 0; i < x.Length; i++)
            {
                counter = 0;
                if (x[i] == digits[i])
                {
                    clock++;
                    if(x[clock] == digits[i])
                    {
                        clock++;
                        counter++;
                    }
                    else
                    {
                        vs.Add(counter);
                    }
                }
                else
                {
                    continue;
                }
                vs.Add(counter);
                counter = 0;
                //if(x[i] == digits[i])
                //{
                //    i++;
                //}
                //vs.Add(i);
                //if (x[i++] == digits[i])
                //{
                //    i++;
                //}
                //if(x[i] == digits[i])
                //{
                //    if(x[i++] == digits[i])
                //    {

                //    }
                //}
                //else
                //{
                //    vs.
                //}
            }
            return vs;
        }
    }

    
}
