using System;
using Algorithms;
using Data;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var t = GetFakeData.GetAll();

            //foreach (var item in t)
            //    Console.WriteLine(item);

            //Console.WriteLine(SearchAlgorithms.LinearSearch("zoe.wright", t));
            //Console.WriteLine("inter" + SearchAlgorithms.InterpolationSearch("zoe.wright", t));

            Console.WriteLine(string.CompareOrdinal("xz", "yx"));
            Console.WriteLine(Algorithms.SearchAlgorithms.StringDiff("x.xx","xxz",3));

            //watch.Stop();
            //TimeSpan times = watch.Elapsed;
            //Console.WriteLine($"{times.Hours:00}:{times.Minutes:00}:{times.Seconds:00}.{times.Milliseconds:00}");

        }
    }
}