using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment1_KF
{
    class Program
    {
            // Function for Question 1
            private static void printTriangle(int n)
            {
            try
            {
                int i, j, k, l;

                for (i = 1; i <= n; i++)
                {
                    for (j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    for (l = i - 1; l >= 1; l--)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }

            }    
            catch (Exception)
            {
                throw;
            }
           

            }

        // Function for Question 2
        private static void printPellSeries(int n2)

        {
            try
            {
                int prior, last, temp;
                prior = 0;
                last = 1;
                Console.Write(prior+", "+ last);
                int i;
                for (i = 3; i <= n2; i++)
                {
                    Console.Write(", ");
                    Console.Write(2 * last + prior);
                    temp = prior;
                    prior = last;
                    last = 2 * prior + temp;


                }

            }
            catch (Exception)
            {
                throw;
            }


        }

        // Function for Question 3
        private static bool squareSums(int n3)

        {
            try
            {
                int  i, j;
                for (i = 0; i < n3; i++)
                {
                    for (j = 0; j < n3; j++)
                    {
                        if (i * i + j * j == n3)
                            return true;
                        
                    }
                }
                return false;

            }
            catch (Exception)
            {
                throw;
            }


        }

        // Function for Question 4
        private static int diffPairs(int[] nums, int k)

        {
            try
            {
                int[] dist = nums.Distinct().ToArray();
                int n = dist.Length;
                int count = 0;

                if (k == 0)
                {
                    Dictionary<int, int> counts = new Dictionary<int, int>();

                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (counts.ContainsKey(nums[i]))
                        {
                            counts[nums[i]] = counts[nums[i]] + 1;
                        }
                        else
                        {
                            counts.Add(nums[i], 1);
                        }
                    }

                    for (int i = 0; i < n; i++)
                    {
                        if (counts[dist[i]] > 1)
                        {
                            count++;
                        }
                    }

                    return count;
                }

                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = i + 1; j < n; j++)
                            if (Math.Abs(dist[i] - dist[j]) == k)
                                count++;
                    }

                    return count;
                }

                return 0;
       
                
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }


        }

        // Function for Question 5
        private static int UniqueEmails(string[] emails)

        {
            try
            {


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


        }


        static void Main(string[] args)
            {

            
            //Question 1
            while (true)
                { 
                    try
                    {
                        Console.Write("Q1 : Enter the number of rows for the traingle:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        printTriangle(n);
                        Console.WriteLine();
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The input is out of range, please enter an integer.");
                    }
                }

            //Question 2
            while (true)
            {
                try
                {
                    Console.WriteLine("Q2 : Enter the number of terms in the Pell Series:");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    printPellSeries(n2);
                    Console.WriteLine();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("The input is out of range, please enter an integer.");
                }
            }

            //Question 3
            while (true)
            {
                try
                {
                    Console.WriteLine("Q3 : Enter the number to check if squareSums exist:");
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    bool flag = squareSums(n3);
                    if (flag)
                    {
                        Console.WriteLine("Yes, the number can be expressed as a sum of squares of 2 integers");
                    }
                    else
                    {
                        Console.WriteLine("No, the number cannot be expressed as a sum of squares of 2 integers");
                    }

                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("The input is out of range, please enter an integer.");
                }
            }

            //Question 4
            while (true)
            {
                try
                {
                    int[] arr = { 3, 1, 4, 1, 5 };
                    Console.WriteLine("Q4: Enter the absolute difference to check");
                    int k = Convert.ToInt32(Console.ReadLine());
                    int n4 = diffPairs(arr, k);
                    Console.WriteLine("There exists {0} pairs with the given difference", n4);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("The input is out of range, please enter an integer.");
                }
            }
        }










    }
    }

