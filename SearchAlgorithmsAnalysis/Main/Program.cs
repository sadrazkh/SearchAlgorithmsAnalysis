using System;
using Data;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = GetFakeData.GetAll();
            Console.WriteLine(t);

            Console.ReadLine();
        }
    }
}
