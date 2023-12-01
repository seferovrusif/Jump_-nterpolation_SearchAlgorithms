using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_İnterpolation_SearchAlgorithms
{
        internal static class SearchAlgorithms
        {
            public static void InterpolationSearchAlgorithm(int[] arr, int x)
            {
                //Interpolation Search
                //It is mainly effective when there are many consecutive and repeated numbers

                int n = arr.Length;
                int index = -1;
                int pos = 0;
                int lo = 0;
                int hi = n - 1;
                for (; true;)
                {
                    if (lo <= hi && x >= arr[lo] && x <= arr[hi])
                    {

                        pos = lo + (((hi - lo) / (arr[hi] - arr[lo])) * (x - arr[lo]));
                        if (arr[pos] == x)
                        {
                            index = pos;

                            break;
                        }
                        if (arr[pos] < x)
                        {
                            lo = pos + 1;

                            continue;
                        }
                        if (arr[pos] > x)
                        {
                            hi = pos - 1;

                            continue;
                        }

                    }
                    else
                    {
                        index = -1;
                        break;
                    }
                }
                if (index != -1)
                    Console.WriteLine("Element found at index " + index + "\n");
                else
                    Console.WriteLine("Element not found.\n");

            }


            public static void JumpSearchAlgorithm(int[] arr, int x)
            {
                int n = arr.Length;
                int index = -1;
                int step = (int)Math.Sqrt(n);
                int prev = 0;
                for (int minStep = Math.Min(step, n) - 1; arr[minStep] < x; minStep = Math.Min(step, n) - 1)
                {
                    prev = step;
                    step += (int)Math.Sqrt(n);
                    if (prev >= n)
                    {
                        index = -1;
                        break;
                    }
                }
                while (arr[prev] < x)
                {
                    prev++;
                    if (prev == Math.Min(step, n))
                    {
                        index = -1;
                        break;
                    }
                }
                if (arr[prev] == x)
                {
                    index = prev;
                }

                if (index == -1)
                {
                    Console.WriteLine("Element not found!\n");
                }
                else
                {
                    Console.Write("Number " + x + " is at index " + index+"\n");
                }

            }

        }
    }
