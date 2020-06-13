using System;
using System.Collections.Generic;
using Algorithms;



namespace TestUnit
{
    public class Tests
    {
        public static int LinearSearchAverage(List<string> data, List<string> testData)
        {
            int total = 0;
            int i = 0;
            foreach (var test in testData)
            {
                i++;
                total += Algorithms.SearchAlgorithms.LinearSearch(test, data);
                
            }

            return total / 58;

        }

        public static int BinarySearchAverage(List<string> data, List<string> testData)
        {
            int total = 0;
            int i = 0;
            foreach (var test in testData)
            {
                i++;
                total += Algorithms.SearchAlgorithms.LinearSearch(test, data);

            }

            return total / 58;
        }
   

        public static float InterAveragetime(List<string> names)
        {
            int total = 0;
            foreach (var item in names)
                total += SearchAlgorithms.InterpolationSearch2(item, names);
            return (float)total / names.Count;

        }
    }
}
