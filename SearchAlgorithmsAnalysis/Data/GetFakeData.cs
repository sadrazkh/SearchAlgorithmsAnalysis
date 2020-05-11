using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace Data
{
    public static class GetFakeData
    {
        private const string _fileName = "chosen_sorted_fake_data.txt";
        
        private static List<string> _fakeData = new List<string>();

        public static List<string> GetAll()
        {
            using 
            foreach (var item in COLLECTION)
            {
                _fakeData.Append(item);
            }
            return _fakeData;
        }

    }
}
