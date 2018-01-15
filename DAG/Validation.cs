using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAG
{
    public static class Validation
    {
        public static bool isValid (IEnumerable <Node> nodes, string name)
        {
            var nameToValidate = nodes.SingleOrDefault(n => n.Name == name); //check if the name exists
            if (nameToValidate != null)
                return true;

            return false;
        }
    }
}
