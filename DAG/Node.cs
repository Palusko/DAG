using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAG
{
    public abstract class Node
    {
        public string Name { get; set; }
        public abstract void Create(string name);
        public abstract void Delete(string name);
        public abstract void Rename(string oldName, string newName);
        //public abstract List<Node> ListOfNodes { get; set; }
        //public abstract bool Validate(string name);
    }
}
