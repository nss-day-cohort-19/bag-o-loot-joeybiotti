using System;
using System.Collections.Generic;
using System.Linq; 
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class SantaClaus
    {
        private List<string> _santa = new List<string>();
        private string _connectionString = $"Data Source={Environment.GetEnvironmentVariable("BAGOLOOT_DB")}";
        private SqliteConnection _connection; 
        public List<int> CheckSantasList(int child)
        {
            return new List<int>(){1,2,3};
        }

        public bool ToysDelievered(int child)
        {
            return true;
        }

        public List <int> RunYuletideReport(int childId)
        {
            return new List<int>(){1,2,323,2323};
        }
    }
}