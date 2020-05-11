using System;
using Algorithms;
using Data;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = GetFakeData.GetAll();
            //foreach (var item in t)
            //    Console.WriteLine(item);

            Console.WriteLine(SearchAlgorithms.LinearSearch("zoe.wright", t));

            //Console.ReadLine();
        }
    }
}