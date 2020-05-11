using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace Data
{
    public static class GetFakeData
    {
        private const string _fileName = @"C:\Users\Sadra\source\repos\sadrazkh\SearchAlgorithmsAnalysis\SearchAlgorithmsAnalysis\Data\chosen_sorted_fake_data.txt";

        private static List<string> _fakeData;

        public static List<string> GetAll()
        {

            using (StreamReader sr = new StreamReader(_fileName))
            {
                string line = sr.ReadLine();
                _fakeData.Add(line);
            }

            return _fakeData;
        }
        

    }
}
