using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAppAPI.ServiceDefinition
{
    public static class APIInfo
    {
        public static Assembly Assembly
        {
            get
            {
                return typeof(APIInfo).Assembly;
            }
        }

        public static readonly string Name = "myFirstApp";
    }
}
