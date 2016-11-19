using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.API.Data.Helpers
{
    public static class DBHelperExtensions
    {
        public static IDBHelper DBHelper(this IDataReader reader)
        {
            return DBHelperFactory(reader);
        }
        public static IDBHelper DBHelper(this object obj)
        {
            return DBHelperFactory(obj);
        }

        static DBHelperExtensions()
        {
            DBHelperFactory = x => new DBHelper(x);
        }

        public static Func<object, IDBHelper> DBHelperFactory { get; set; }


    }
}
