using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
   public class SantaHelper
    {
        private List <string> _santasHelper = new List<string>();
        private string _connectionString = $"Data Source={Environment.GetEnvironmentVariable("BAGOLOOT_DB")}";
        private SqliteConnection _connection;
        public int AddToyToBag(string toy, int child)
        {
            return 4;
        }
        public List <int> GetChildsToys(int toy)
        {
            return new List<int>(){4,6,7,8};
        }
        public int RemoveToyFromBag(string toy, int child)
        {
            return 10;
        }
    }

}