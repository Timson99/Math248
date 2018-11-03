using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace AsimovProject{
    class Path1{
        //List of all event nodes, labled by path choices. All must be listed up here.
        private EventNode entryNode;
        private EventNode A;
        private EventNode B;
        private EventNode AA;
        private EventNode AB;
        private EventNode BA;
        private EventNode BB;
        //etc.

        public Path1(){
            //Create Event Nodes Starting from Entry Node
            //List path fields together to create a tree structure
            // Ex AAB.setPath(0,AABA)   AAB.setPath(1,AABB)

            /////////////////////////////////////////////////entryNode
            List<string> temp = new List<string>();
            //temp.Add("kirk or something"); 
            entryNode = new EventNode("space2", temp, 2, "This is the beginning of Path1");
            temp.Clear();
            entryNode.setPath(0, A);
            entryNode.setPath(1, B);
            /////////////////////////////////////////////
            ///
            ////////////////////////////////////////////
            //set for A: say hello or approach Captain Quirk
            //temp.Add() for the sprites
            A = new EventNode("space2",temp,2,"for decision A");
            temp.Clear();
            A.setPath(0, AA);
            A.setPath(1, AB);
            //////////////////////////////////////////
            //entry for B 
            B = new EventNode("space2", temp, 2,"for decision B");
            temp.Clear();
            B.setPath(0, BA);
            B.setPath(1, BB);

            //////////////////////////////////////////
            //
            //AA = new EventNode("space2",temp)
      
        


            /////////////////////////////////////////////////

        }
        public EventNode getEntryNode(){
            return entryNode;
        }
    }
}
