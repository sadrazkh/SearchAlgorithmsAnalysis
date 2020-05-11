using System;
using System.Collections.Generic;


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
            string res = $"{time.Hours}:{time.Minutes}:{time.Seconds}.{time.Milliseconds}";
            //string res = time.ToString();
            //https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?view=netcore-3.1
            return res;
        }

    }
}
