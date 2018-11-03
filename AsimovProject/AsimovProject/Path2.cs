using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace AsimovProject { 
    class Path2 {
        //List of all event nodes, labled by path choices. All must be listed up here.
        private EventNode entryNode;
        private EventNode A;
        private EventNode B;
        //private EventNode C;
        private EventNode AA;
        private EventNode AB;
        private EventNode BA;
        private EventNode BB;

        //etc.
        public Path2(){
            // entrynode for path 2
            List<string> temp = new List<string>();
            entryNode = new EventNode("space2", temp, 2, "This is the beginning of Path2");
            temp.Clear();
            entryNode.setPath(0, A);
            entryNode.setPath(1, B);

            ////////////// for A 
            A = new EventNode("space2", temp, 2, "for decision A");
            temp.Clear();
            A.setPath(0, AA);
            A.setPath(1, AB);


            ////// for B 
            B = new EventNode("space2", temp, 2, "for decision B");
            temp.Clear();
            B.setPath(0,BA);
            B.setPath(1, BB);

            //Create Event Nodes Starting from Entry Node
            //List path fields together to create a tree structure
            // Ex AAB.setPath(0,AABA)   AAB.setPath(1,AABB)
        }
        public EventNode getEntryNode(){
            return entryNode;
        }
    }
}
