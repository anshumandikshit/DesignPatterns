using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public class DummyDatabase : IDatabase
    {
        private Dictionary<string, int> dummydata;
        public DummyDatabase()
        {
            dummydata = new Dictionary<string, int>();
            dummydata["data1"] = 123456;
            dummydata["data2"] = 3456;
            dummydata["data3"] = 2345;


        }
        public int GetPopulation(string name)
        {
            return dummydata[name];
        }
    }
}
