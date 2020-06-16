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

            List<int> index = Algorithms.SearchAlgorithms.Percentages(allData);

            //Console.WriteLine(Tests.LinearSearchAverage(allData,testData));
            //Console.WriteLine(Tests.BinarySearchAverage(allData, testData));
            //for (int i = 0; i < 21; i++)
            //{
            //    Console.WriteLine(Tests.CombinationTest(allData,testData,i));
            //}
            //Console.WriteLine(Tests.InterpolationSearch1Test(allData, testData));
            //Console.WriteLine(Tests.InterpolationSearch2Test(allData, testData));
            Console.WriteLine(Tests.InterpolationSearchnewTest(allData, testData, index));


        }


    }
}