using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace Data
{
    public static class GetFakeData
    {
        

        private static List<string> _fakeData = new List<string>();
        private static List<string> _fakeData1 = new List<string>();

        public static List<string> GetAll()
        {
            string _fileName = Directory.GetCurrentDirectory() + "\\..\\..\\..\\..\\data\\FakeData.txt";
            using (StreamReader sr = new StreamReader(@_fileName))
            {
                for (int i = 0; sr.Peek() > -1 ; i++)
                {
                    string line = sr.ReadLine();
                    _fakeData.Add(line);
                }
            }

            return _fakeData;
        }

        public static List<string> GetTestData()
        {
            string _fileName = Directory.GetCurrentDirectory() + "\\..\\..\\..\\..\\data\\chosen_sorted_fake_data.txt";
            using (StreamReader sr = new StreamReader(@_fileName))
            {
                for (int i = 0; sr.Peek() > -1; i++)
                {
                    string line = sr.ReadLine();
                    _fakeData1.Add(line);
                }
            }
            //List<string> _fakeData = new List<string>(){ "alex.smith", "eric.graves", "juan.garcia", "laura.cross", "sandeep.shukla" };

            return _fakeData1;
        }

        // kooft
    }
}
