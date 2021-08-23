using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public class SingletonDatabase : IDatabase
    {
        //For a singleton class  the class must be instantiated only once
        //so better approach is to create rivate constructor and then expoe the class in terms of static field .


        private Dictionary<string, int> cities;

        //Creating a static property so that this can only create one instance ultimately
        private static SingletonDatabase instance = new SingletonDatabase();

        //And that instance will be exposed to the outer environement by using this property
        public static SingletonDatabase Instance => instance;
       
        private SingletonDatabase()
        {
            //Creating a dummy database sample in terms of cities

            cities = new Dictionary<string, int>();
            cities.Add("bhubaneswar", 1234);
            cities.Add("delhi", 123456);
            cities.Add("mumbai", 600000);
            cities.Add("bangalore", 40000);

        }
        public  int GetPopulation(string name)
        {
            return cities[name];
        }
    }
}
