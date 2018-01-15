using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAG
{
    public static class Messages
    {
        public static void InvalidName (string name)
        {
            Console.WriteLine($"The {name} doesn't exist");
        }
    }
}
