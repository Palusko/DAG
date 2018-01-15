using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAG
{
    public class ShapeNode : Node
    {
        TransformNode txNode;
        public static IEnumerable<ShapeNode> ListOfShapes;

        public override void Create(string name)
        {
            if (Validation.isValid(ListOfShapes, name))
            {
                ListOfShapes.ToList().Add(new ShapeNode { Name = name });
            }                
            else
                Messages.InvalidName(name);
        }

        public override void Delete(string name)
        {
            var itemToRemove = ListOfShapes.SingleOrDefault(n => n.Name == name);
            if (itemToRemove != null)
                ListOfShapes.ToList().Remove(itemToRemove);
            else
                Messages.InvalidName(name);
        }

        public override void Rename(string oldName, string newName)
        {
            if (!Validation.isValid(ListOfShapes, oldName))
            {
                Messages.InvalidName(oldName);
                return;
            }

            if (!Validation.isValid(ListOfShapes, newName))
            {
                Messages.InvalidName(newName);
                return;
            }

            var toRename = ListOfShapes.ToList().FindIndex(n => n.Name == oldName);
            ListOfShapes.ToList()[toRename].Name = newName;
        }
        
    }
}
