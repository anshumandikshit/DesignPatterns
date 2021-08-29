using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public class ConfigurableDatabase
    {
        private readonly IDatabase _database;

        public ConfigurableDatabase(IDatabase database)
        {
            _database = database ?? throw new ArgumentNullException(nameof(database));
        }

        public int GetTotalopulation(IEnumerable<string> names)
        {
            int result = 0;
            foreach(var name in names)
            {
                result += _database.GetPopulation(name);
            }

            return result;
        }
    }
}
