using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Vyberi progy nazhmi 1");
                x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Random y = new Random();
                        int r = y.Next(0, 100);
                        Console.WriteLine(r);
                        do
                        {
                            int a;
                            Console.WriteLine("ygaduvaj");
                            a = int.Parse(Console.ReadLine());
                            if (a == r)
                            {
                                Console.WriteLine("ygadal");
                                x = 2;
                                break;
                            }
                            else if (a > r)
                            {

                                while (a > r)
                                {
                                    Console.WriteLine("Nado menshe\n vvedi esche raz");

                                    a = int.Parse(Console.ReadLine());
                                    if (a < r)
                                    {
                                        while (a < r)
                                        {
                                            Console.WriteLine("Nado bolshe");
                                            a = int.Parse(Console.ReadLine());
                                            if (a < r)
                                            {

                                                continue;
                                            }
                                            else if (a == r)
                                            {
                                                Console.WriteLine("ygadal");
                                                x = 2;
                                                break;
                                            }

                                        }




                                    }
                                    else if (a == r)
                                    {

                                        Console.WriteLine("Molodets");
                                        x = 2;
                                    }
                                    else if (a > r)
                                    {

                                        continue;
                                    }
                                }


                            }
                            else if (a < r)
                            {

                                while (a < r)
                                {
                                    Console.WriteLine("Nado bolshe\n vvedi esche raz");

                                    a = int.Parse(Console.ReadLine());
                                    if (a > r)
                                    {
                                        while (a > r)
                                        {
                                            Console.WriteLine("Nado menshe");
                                            a = int.Parse(Console.ReadLine());
                                            if (a < r)
                                            {

                                                continue;
                                            }
                                            else if (a == r)
                                            {
                                                Console.WriteLine("ygadal");
                                                x = 2;
                                                break;
                                            }

                                        }



                                    }
                                    else if (a == r)
                                    {

                                        Console.WriteLine("Molodets");
                                        x = 2;
                                        break;
                                    }
                                    else if (a < r)
                                    {


                                        continue;
                                    }
                                }
                            }
                        } while (x == 1);
                        break;
                    case 2:

                        int[] t = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        int p;



                        for (int b = 0; b < t.Length; b++)
                        {
                            Console.Write($"  {t[b]}\t");
                        }
                        Console.WriteLine("\n");
                        for (int c = 0; c < t.Length; c++)
                        {
                            Console.Write($"  {p = t[0] * t[c]}\t  " +
                                $"{p = t[1] * t[c]}\t  " +
                                $"{p = t[2] * t[c]}\t  " +
                                $"{p = t[3] * t[c]}\t  " +
                                $"{p = t[4] * t[c]}\t  " +
                                $"{p = t[5] * t[c]}\t  " +
                                $"{p = t[6] * t[c]}\t  " +
                                $"{p = t[7] * t[c]}\t  " +
                                $"{p = t[8] * t[c]}\t\n");
                        }



                        break;
                    case 3:
                        int q;
                        Console.WriteLine("Vvedite chislo jopta");
                        q = int.Parse(Console.ReadLine());


                        for (int i = 1; i <= q; i++)
                        {
                            int w;
                            w = q % i;
                            if (w == 0)
                            {
                                Console.Write(i + "\t");

                            }
                        }

                        Console.WriteLine(" \n ");
                       

                        break;
                    case 4:
                        
                        break;

                }

            } while (x!=4);
        }
    }
}
