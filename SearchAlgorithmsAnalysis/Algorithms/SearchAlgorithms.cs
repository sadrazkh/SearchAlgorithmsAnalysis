using System;
using System.Collections.Generic;


namespace Algorithms
{
    public class SearchAlgorithms
    {
        public static long LinearSearch(string element, List<string> namesList)
        {
            var watch = new System.Diagnostics.Stopwatch();
            int a = namesList.Capacity;
            int i = 0;
            watch.Start();
            while (i < a && namesList[i] != element)
                i++;
            watch.Stop();
            long time = watch.ElapsedMilliseconds;
            return time;
        }



    }
}
