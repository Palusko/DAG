using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAG
{
    public class TransformNode : Node
    {
        private ShapeNode shape;
        public static IEnumerable<TransformNode> ListOfRootNodes;

        public override void Create(string name)
        {
            throw new NotImplementedException();
        }

        public override void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public override void Rename(string oldName, string newName)
        {
            throw new NotImplementedException();
        }
        
    }
}
