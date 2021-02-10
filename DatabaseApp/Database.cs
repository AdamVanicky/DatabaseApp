using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseApp
{
    class Database
    {
        public Dictionary<string, Person> databaze;
        private static readonly object locking = new object();
        static Database instance = null;

        private Database()
        {
            databaze = new Dictionary<string, Person>();
        }

        public static Database CreateOne
        {
            get
            {
                lock (locking)
                {
                    if (instance == null)
                    {
                        instance = new Database();
                    }
                }
                return instance;
            }
        }
    }
}
