using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace AsimovProject
{
    class Path2
    {
        EventNode entryNode;
        EventNode currentNode;
        public Path2()
        {
            //Create Event Nodes Starting from Entry Node and link path fields together
        }

        public EventNode getCurrentNode()
        {
            return currentNode;
        }
        public void nextNode(int path)
        {
            currentNode = currentNode.getPaths()[path];
        }
    }
}
