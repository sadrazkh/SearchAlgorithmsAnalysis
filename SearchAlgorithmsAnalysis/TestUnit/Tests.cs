using System;
using System.Collections.Generic;
using Algorithms;



namespace TestUnit
{
    public class Tests
    {
        public static float LinAveragetime(List<string> names)
        {
            int total = 0;
            foreach (var item in names)
                total += SearchAlgorithms.LinearSearch(item, names);
            return (float)total / names.Count;

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
