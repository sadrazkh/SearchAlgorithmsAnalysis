using System;
using System.Collections.Generic;
using System.Threading;


namespace Algorithms
{
    public class SearchAlgorithms
    {
        public static int LinearSearch(string element, List<string> namesList)
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

            //string res = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds:00}";
            return time.Milliseconds;

        }


        private static int linear_search(string element, List<string> namesList, int low, int high)
        {
            int i = low;
            while (low < high && namesList[i] != element)
                i++;
            if (namesList[i - 1].Equals(element))
                return i - 1;
            return 0;
        }


        public static int InterpolationSearch2(string element, List<string> namesList)
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
                        break;
                    }
                }
                d= (double)StringDiff(element, namesList[first], 2) / StringDiff(namesList[last], namesList[first], 2);
                b = (int)((last - first) * d);
                if (namesList[b].Equals(element))
                {
                    watch1.Stop();
                    break;
                }
                if (namesList[b].CompareTo(element) < 0)
                    first = b + 1;

                else
                    last = b -1;
            }
            TimeSpan time1 = watch1.Elapsed;
            //string res1 = $"{time1.Hours:00}:{time1.Minutes:00}:{time1.Seconds:00}.{time1.Milliseconds:00}";
            return time1.Milliseconds;
        }

        public static int InterpolationSearch1(string element, List<string> namesList)
        {
            var watch1 = new System.Diagnostics.Stopwatch();
            int first = 0, last = namesList.Count - 1;

            watch1.Start();
            int b=0;
            double d;
            while (first <= last && namesList[first].CompareTo(element) <= 0 && namesList[last].CompareTo(element) >= 0)
            {
                if (first == last)
                {
                    if (namesList[first].Equals(element))
                    {
                        watch1.Stop();
                        Console.WriteLine(namesList[first]);
                        break;
                    }
                }
                d = (double)StringDiff(element, namesList[first], 1) / StringDiff(namesList[last], namesList[first], 1);
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
                    last = b - 1;

            }
            TimeSpan time1 = watch1.Elapsed;
            //string res1 = $"{time1.Hours:00}:{time1.Minutes:00}:{time1.Seconds:00}.{time1.Milliseconds:00}";
            return time1.Milliseconds;
        }

        public static int InterpolationSearch_new(string element, List<string> namesList, List<int> indexes)
        {
            int first = (element.StartsWith('a')) ? 0 : indexes[(int)element[0] - 97 - 1];
            int last = indexes[(int)element[0]-97];
            return linear_search(element, namesList , first , last);
        }


        private static int StringDiff(string s1, string s2, int num)
        {
            int diff = 0;
            for (int i = 0; i < num; i++)
                diff += (s1[i] - s2[i])* (int)Math.Pow(10,num-1);
            return diff;
        }

        public static List<int> Percentages(List<string> a)
        {
            List<int> result = new List<int>(new int[26]);
            foreach(var element in a)
            {
                result[(int)element[0] - 97]++;
            }
            for(int i=0;i<26;i++)
            {
                if (i != 0)
                    result[i] += result[i - 1];
            }
            return result;
        }



        //Mahmood Functions
        public static int binarynnorecursive(int low, int high, List<string> s, string x, int n)
        {
            var watch = new System.Diagnostics.Stopwatch();
            TimeSpan time;
            while (low <= high)
            {
                if (x == s[low])
                    return low;
                if (x == s[high])
                    return high;
                int mid, lengh, i;
                int[] d = new int[2];
                lengh = (high - low + 1);
                if (lengh < n)
                    n = 2;
                mid = lengh / n;
                d[1] = low;
                for (i = 1; i < n; i++)
                {
                    d[0] = d[1];
                    d[1] = i * mid;
                    if (x == s[d[1]])
                    {
                        watch.Stop();
                        time = watch.Elapsed;

                        //string res = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds:00}";
                        return time.Milliseconds;
                        return d[1];
                    }
                    else if (x.CompareTo(s[d[1]]) < 0)
                    {
                        low = d[0] + 1;
                        high = d[1] - 1;
                        break;
                    }
                }
                if (i == n)
                {
                    low = d[1] + 1;
                    high = high - 1;
                }
            }

            watch.Stop();
            time = watch.Elapsed;

            //string res = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds:00}";
            return time.Milliseconds;
            
        }

        //

        public static int Binaryn(int low, int high, List<string> s, string x, int n)
        {

            if (low > high)
                return 0;
            if (x == s[low])
                return low;
            if (x == s[high])
                return high;
            int mid, lengh, i;
            int[] d = new int[2];
            lengh = (high - low + 1);
            if (lengh < n)
                n = 2;
            mid = lengh / n;
            d[1] = low;
            for (i = 1; i < n; i++)
            {
                d[0] = d[1];
                d[1] = i * mid;
                if (x == s[d[1]])
                {
                    return d[1];
                }
                else if (x.CompareTo(s[d[1]]) < 0)
                {
                    return Binaryn(d[0] + 1, d[1] - 1, s, x, n);
                }
                return 0;
            }
            if (i == n)
            {
                return Binaryn(d[1] + 1, high - 1, s, x, n);
            }
            return 0;
        }


        public static int combination(string x, List<string> s, int low, int high, int n, int m)
        {
            var watch = new System.Diagnostics.Stopwatch();
            while (high - low > m)
            {
                if (x == s[low])
                    return low;
                if (x == s[high])
                    return high;
                int mid, lengh, i;
                int[] d = new int[2];
                lengh = (high - low + 1);
                if (lengh <= n)
                    n = 2;
                mid = lengh / n;
                d[1] = low;
                for (i = 1; i < n; i++)
                {
                    d[0] = d[1];
                    d[1] = i * mid;
                    if (x == s[d[1]])
                    {
                        return d[1];
                    }
                    else if (x.CompareTo(s[d[1]]) < 0)
                    {
                        low = d[0] + 1;
                        high = d[1] - 1;
                        break;
                    }
                }
                if (i == n)
                {
                    low = d[1] + 1;
                    high = high - 1;
                }
            }
            return linear_search(x, s, low, high);
        }


        public static int hybrid_search(string obj, List<string> data, int first, int last)
        {
            var watch = new System.Diagnostics.Stopwatch();
            bool use_binary_search = false;

            while (last - first > 16)
            {
                int midpoint = (first + last) / 2;
                double d = (double)StringDiff(obj, data[first], 2) / StringDiff(data[last], data[first], 2);
                int a = (int)((last - first) * d);
                int b = use_binary_search ? midpoint : a;

                if (obj == data[b])
                {
                    return b;
                }
                else if (obj.CompareTo(data[b]) < 0)
                {
                    last = b - 1;
                    use_binary_search = (midpoint < b);
                }
                else
                {
                    first = b + 1;
                    use_binary_search = (midpoint > b);
                }

            }

            int i = first;
            while (first < last && data[i] != obj)
                i++;
            if (data[i - 1].Equals(obj))
                return i - 1;

            TimeSpan time1 = watch.Elapsed;
            //string res1 = $"{time1.Hours:00}:{time1.Minutes:00}:{time1.Seconds:00}.{time1.Milliseconds:00}";
            return time1.Milliseconds;
        }

    }
};
