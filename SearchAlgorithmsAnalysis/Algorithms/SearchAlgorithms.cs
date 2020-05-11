using System;
using System.Collections.Generic;
using System.Threading;


namespace Algorithms
{
    public class SearchAlgorithms
    {
        public static string LinearSearch(string element, List<string> namesList)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int a = namesList.Capacity;
            int i = 0;
            watch.Start();
            //Thread.Sleep(3000);
            while (i < a && namesList[i] != element)
                i++;
            watch.Stop();
            TimeSpan time = watch.Elapsed;

            string res = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds:00}";
            return res;
        }



        public static string InterpolationSearch(string element, List<string> namesList)
        {
            var watch1 = new System.Diagnostics.Stopwatch();
            int first = 0, last = namesList.Count - 1;

            watch1.Start();
            int b;
            double d;
            while(first<=last  &&  namesList[first].CompareTo(element) <= 0  && namesList[last].CompareTo(element) >= 0)
            {
                if(first==last)
                {
                    if (namesList[first].Equals(element))
                    {
                        watch1.Stop();
                        Console.WriteLine(namesList[first]);
                        break;
                    }
                }
                d= (double)StringDiff(element, namesList[first], 3) / StringDiff(namesList[last], namesList[first], 3);
                b = (int)((last - first) * d);
                if (namesList[b].Equals(element))
                {
                    watch1.Stop();
                    Console.WriteLine(namesList[b]);
                    break;
                }
                if (namesList[b].CompareTo(element) < 0)
                    first = b + 1;

                else
                    last = b -1;

            }
            TimeSpan time1 = watch1.Elapsed;
            string res1 = $"{time1.Hours:00}:{time1.Minutes:00}:{time1.Seconds:00}.{time1.Milliseconds:00}";
            return res1;
        }


        private static int StringDiff(string s1, string s2, int num)
        {
            int diff = 0;
            for (int i = 0; i < num; i++)
                diff += s1[i] - s2[i];
            return diff;
        }
    }
};
