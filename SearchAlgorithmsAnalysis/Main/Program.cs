using System;
using Algorithms;
using Data;
using TestUnit;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            //var watch = new System.Diagnostics.Stopwatch();
            //watch.Start();
            var allData = GetFakeData.GetAll();
            var testData = GetFakeData.GetTestData();
            //List<int> indexes = SearchAlgorithms.Percentages(t);

            Console.WriteLine(TestUnit.Tests.LinearSearchAverage(allData,testData));


            //foreach (var item in t)
            //    Console.WriteLine(item);

            //Console.WriteLine("LinearSearch:" + SearchAlgorithms.LinearSearch("zoe.wright", t) + " ms");
            //Console.WriteLine("InterpolationSearch2:" + SearchAlgorithms.InterpolationSearch2("zoe.wright", t) + " ms");
            //Console.WriteLine("Interpolation Average:" + Tests.InterAveragetime(t));
            //watch.Stop();
            //TimeSpan times = watch.Elapsed;
            //Console.WriteLine($"{times.Hours:00}:{times.Minutes:00}:{times.Seconds:00}.{times.Milliseconds:00}");

        }

        
    }
}