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

            Console.WriteLine(SearchAlgorithms.LinearSearch("zoe.wright", t));
            watch.Stop();
            TimeSpan times = watch.Elapsed;
            Console.WriteLine($"{times.Hours:00}:{times.Minutes:00}:{times.Seconds:00}.{times.Milliseconds:00}");

            //Console.ReadLine();
        }
    }
}