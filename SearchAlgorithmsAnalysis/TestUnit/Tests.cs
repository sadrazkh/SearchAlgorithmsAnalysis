using System;
using System.Collections.Generic;
using Algorithms;



namespace TestUnit
{
    public class Tests
    {
        public static string LinearSearchAverage(List<string> data, List<string> testData)
        {
            int total = 0;
            int i = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            foreach (var test in testData)
            {
                i++;
                total += Algorithms.SearchAlgorithms.LinearSearch(test, data);
                
            }
            watch.Stop();
            TimeSpan time = watch.Elapsed;

            //string res = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds:00}";
            return $"{time.Milliseconds} ms for {testData.Count} cases in Linear Search";

            //return total / numberOfTestData;

        }

        public static string BinarySearchAverage(List<string> data, List<string> testData)
        {
            int total = 0;
            int i = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            foreach (var test in testData)
            {
                i++;
                total += Algorithms.SearchAlgorithms.binarynorecursive(data, test);

            }

            watch.Stop();
            TimeSpan time = watch.Elapsed;

            //string res = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds:00}";
            return $"{time.Milliseconds} ms for {testData.Count} cases";

            //return total / numberOfTestData;
        }

        public static string CombinationTest(List<string> data, List<string> testData, int threshold)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            foreach (var test in testData)
            {
                Algorithms.SearchAlgorithms.FinalCombination(data, test, threshold);
            }
            watch.Stop();
            TimeSpan time = watch.Elapsed;

            //string res = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds:00}";
            return $"{time.Milliseconds} ms for {testData.Count} cases in Combinational Search & threshold = {threshold} ";

            //return total / numberOfTestData;
        }

        public static string InterpolationSearch1Test(List<string> data, List<string> testData)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            foreach (var test in testData)
            {
                Algorithms.SearchAlgorithms.InterpolationSearch1(test, data);
            }
            watch.Stop();
            TimeSpan time = watch.Elapsed;

            //string res = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds:00}";
            return $"{time.Milliseconds} in {testData.Count} case";

        }
        public static string InterpolationSearch2Test(List<string> data, List<string> testData)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            foreach (var test in testData)
            {
                Algorithms.SearchAlgorithms.InterpolationSearch2(test, data);
            }
            watch.Stop();
            TimeSpan time = watch.Elapsed;

            //string res = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds:00}";
            return $"{time.Milliseconds} in {testData.Count} case";
        }
        public static string InterpolationSearchnewTest(List<string> data, List<string> testData, List<int> index)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            foreach (var test in testData)
            {
                Algorithms.SearchAlgorithms.InterpolationSearch_new(test, data, index);
            }
            watch.Stop();
            TimeSpan time = watch.Elapsed;

            //string res = $"{time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}.{time.Milliseconds:00}";
            return $"{time.Milliseconds} ms for {testData.Count} cases in Interpolation Search";
        }

    }
}
