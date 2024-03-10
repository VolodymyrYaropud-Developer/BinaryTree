using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BinaryTree
{
    internal class MyBinaryTree
    {
        public Node Root { get; set; } = null;

        public void Add(int value)
        {
            if (Root != null)
            {
                Root.Insert(value);
            }
            else
            {
                Root = new Node(value);
            }
        }
    }
}
