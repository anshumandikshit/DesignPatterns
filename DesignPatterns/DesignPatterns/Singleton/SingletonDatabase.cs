using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public class SingletonDatabase : IDatabase
    {
        //For a singleton class  the class must be instantiated only once
        //so better approach is to create private constructor and then expose the class in terms of static field .


        private Dictionary<string, int> cities;

        //These will be used at the time of unittesting to check how many instance is getting created ;
        private static int instanceCount;
        public static int InstanceCount => instanceCount;

        //Creating a static property so that this can only create one instance ultimately
        private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(()=> new SingletonDatabase());

        //And that instance will be exposed to the outer environement by using this property
        public static SingletonDatabase Instance => instance.Value;
       
        private SingletonDatabase()
        {
            //Creating a dummy database sample in terms of cities

            //this will be useful to create the unittest cases 
            instanceCount++;

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
