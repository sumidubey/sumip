using System;
using System.Collections.Generic;
using System.Text;

namespace TeamProject
{
    class ArrayP
    {       static void Main()
            {
                Console.WriteLine("Please enter the size of array: ");

                int a;
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a);
                int[,] ar = new int[a, a];

                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        ar[i, j] = 0;
                    }
                }
                ar[a - 1, 0] = 1;
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        Console.Write(ar[i, j]);
                    }
                    Console.Write("\n");
                }
                int q = 1;
                int n;
                int r, c;



                while (q == 1)
                {
                    Console.WriteLine("Enter the integer values as below: ");
                    Console.Write(" =>2 for UP<= ");
                    Console.Write(" => 4 for LEFT<= ");
                    Console.Write(" =>6 for Right<= ");
                    Console.Write(" =>8 for Down<= ");
                    Console.Write(" =>0 for Exit<= ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n == 0)
                    {
                        q = 0;
                    }
                    else
                    {
                        r = 0;
                        c = 0;
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < a; j++)
                            {
                                if (ar[i, j] == 1)
                                {
                                    r = i;
                                    c = j;
                                }
                            }
                        }
                        if (n == 2)
                        {
                            if (r == 0)
                            {
                                r = 0;
                            }
                            else
                            {
                                ar[r, c] = 0;
                                ar[r - 1, c] = 1;
                            }
                        }
                        else if (n == 8)
                        {
                            if (r == a - 1)
                            {
                                r = a - 1;
                            }
                            else
                            {
                                ar[r, c] = 0;
                                ar[r + 1, c] = 1;
                            }
                        }
                        else if (n == 4)
                        {
                            if (c == 0)
                            {
                                c = 0;
                            }
                            else
                            {
                                ar[r, c] = 0;
                                ar[r, c - 1] = 1;
                            }
                        }
                        else if (n == 6)
                        {
                            if (c == a - 1)
                            {
                                c = a - 1;
                            }
                            else
                            {
                                ar[r, c] = 0;
                                ar[r, c + 1] = 1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You have entered wrong key ");
                        }
                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < a; j++)
                            {
                                Console.Write(ar[i, j]);
                            }
                            Console.Write("\n");
                        }
                    }
                }


            }
        }







    }





