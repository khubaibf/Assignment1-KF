﻿using System;
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
                // print first two terms
                Console.Write(prior + ", " + last);
                int i;

                // print remaining terms
                for (i = 3; i <= n2; i++)
                {
                    Console.Write(", ");
                    // print next term
                    Console.Write(2 * last + prior);
                    // update terms as sequesnce progresses
                    temp = prior;
                    prior = last;
                    last = 2 * prior + temp;


                }

            }
            // catch and throw any exception that may occur
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
                int i, j;
                // nested for loops to consider sum of squares of all combinations of numbers less than n3
                for (i = 0; i < n3; i++)
                {
                    for (j = 0; j < n3; j++)
                    {
                        // if found valid sum of squares, return true
                        if (i * i + j * j == n3)
                            return true;

                    }
                }
                // if no combination found, return false
                return false;

            }
            // catch and throw any exception that may occur
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
                // create array of distinct numbers in array
                int[] dist = nums.Distinct().ToArray();
                // set n equal to number of distinct numbers
                int n = dist.Length;
                int count = 0;

                // base case k = 0
                if (k == 0)
                {
                    // create dictionary to store how many times each number occurs in original array
                    Dictionary<int, int> counts = new Dictionary<int, int>();

                    // for loop calculates no. of occurences
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

                    // return number of 0-diff pairs
                    for (int i = 0; i < n; i++)
                    {
                        if (counts[dist[i]] > 1)
                        {
                            count++;
                        }
                    }

                    return count;
                }
                // for all else k
                else
                {
                    // compare all distinct pairs
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = i + 1; j < n; j++)
                            // if a pair is found, increment count
                            if (Math.Abs(dist[i] - dist[j]) == k)
                                count++;
                    }
                    // return count
                    return count;
                }

                return 0;


            }
            // catch and throw any exception that may occur
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }


        }

        // Function for Question 5
        private static int UniqueEmails(List<string> emails)

        {
            try
            {
                string domain = "";
                string local = "";

                // create dictionary where each key is a unique domain, and its value is HashSet of unique local addresses in it
                Dictionary<string, HashSet<string>> domains = new Dictionary<string, HashSet<string>>();

                // for each email, seplit local and domain name, and remove . and + plus following characters
                foreach (var email in emails)
                {
                    local = email.Split('@')[0];
                    domain = email.Split('@')[1];

                    local = local.Replace(".", "");

                    local = local.Remove(local.IndexOf('+'));

                    // update hashset of domain or insert in dict
                    if (domains.ContainsKey(domain))
                    {
                        domains[domain].Add(local);
                    }
                    else
                    {
                        domains.Add(domain, new HashSet<string>());
                        domains[domain].Add(local);
                    }
                }

                int count = 0;

                // count unique addresses and return
                foreach (var k in domains.Keys)
                {
                    count += domains[k].Count;
                }

                return count;

            }
            // catch and throw any exception that may occur
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }


        }

        // Function for Question 6
        private static string DestCity(string[,] paths)

        {
            try
            {
                // insert all cities in All hashset
                HashSet<string> All = new HashSet<string>();
                // insert only outgoing cities in outgoing Hashset
                HashSet<string> Outgoing = new HashSet<string>();

                for (int i=0; i<paths.GetLength(0); i++)
                {
                    All.Add(paths[i,0]);
                    All.Add(paths[i, 1]);

                    Outgoing.Add(paths[i, 0]);
                }

                // use Except() function to find city which is not in the outgoing hashset and return
                if (All.ToArray().Except(Outgoing.ToArray()).ToArray().Length != 0 )
                {
                    return All.ToArray().Except(Outgoing.ToArray()).ToArray()[0];
                }
                // return empty if no such city
                return "";
            }
            // catch and throw any exception that may occur
            catch (Exception)
            {
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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
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
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
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
                catch (Exception e)
                {
                    Console.WriteLine("An error occured: " + e.Message);
                    throw;
                }

            }

            //Question 5
            while (true)
            {
                try
                {
                    List<string> emails = new List<string>();
                    emails.Add("dis.email+bull@usf.com");
                    emails.Add("dis.e.mail+bob.cathy@usf.com");
                    emails.Add("disemail+david@us.f.com");
                    int ans5 = UniqueEmails(emails);
                    Console.WriteLine("Q5");
                    Console.WriteLine("The number of unique emails is " + ans5);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }


            }

            //Question 6
            while (true)
            {
                try
                {
                    string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" }, { "Delhi", "London" } };
                    string destination = DestCity(paths);
                    Console.WriteLine("Q6");
                    Console.WriteLine("Destination city is " + destination);
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                    Console.ReadLine();
                }
            }











        }
    }
}

