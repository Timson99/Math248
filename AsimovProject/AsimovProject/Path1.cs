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

    //Captain Quirk
    class Path1{
        //List of all event nodes, labled by path choices. All must be listed up here.
        private EventNode entryNode;
        private EventNode A;
        private EventNode B;
        private EventNode C;
        private EventNode AA;
        private EventNode BA;
        private EventNode BB;
        private EventNode BAA;
        private EventNode BAB;
        private EventNode BAC;



        //etc.

        public Path1(){
            //Create Event Nodes Starting from Entry Node
            //List path fields together to create a tree structure
            // Ex AAB.setPath(0,AABA)   AAB.setPath(1,AABB)

            /////////////////////////////////////////////////entryNode
            List<string> temp = new List<string>();
            temp.Add("RoboHap");
            temp.Add("Quirk");
            entryNode = new EventNode("sky", temp, 2, "See Captain Quirk: A: Insult B: Approach");
            temp.Clear();
            
            
            ////////////////////////////////////////////
            //set for A: say hello or approach Captain Quirk
            // ADD CRYING QUIRK
            temp.Add("Quirk");
            A = new EventNode("glowyGrass", temp, 1, "Game over he cried");
            temp.Clear();

            //////////////////////////////////////////
            //entry for B 
            temp.Add("RoboHap");
            temp.Add("Quirk");
            B = new EventNode("dino", temp, 2," \"I have a problem\": A: Listen B: Say \"Is it your tiny hands\"?");
            temp.Clear();

            //////////////////////////////////////////
            //entry for BA
            temp.Add("Quirk");
            BA = new EventNode("dino", temp, 3, "\"Can you console me\" : A Firm Hug B: Take out drinking C: Show him your knife");
            temp.Clear();

            //////////////////////////////////////////
            //entry for BB
            temp.Add("Quirk");
            BB = new EventNode("dino", temp, 1, "Game over he cried");
            temp.Clear();

            //////////////////////////////////////////
            //entry for BAA
            // INSERT BLOODY QUIRK
            temp.Add("RoboHap");
            BAA = new EventNode("dino", temp, 2, "Win");
            temp.Clear();

            //////////////////////////////////////////
            //entry for BAB
            // INSERT BLOODY QUIRK
            temp.Add("RoboMad");
            BAB = new EventNode("dino", temp, 1, "Game over he vomited which demonstates harm");
            temp.Clear();

            //////////////////////////////////////////
            //entry for BAC
            // INSERT CRYING QUIRK
            temp.Add("RoboMad");
            BAC = new EventNode("dino", temp, 1, "Game over he bled");
            temp.Clear();

   


            //////////////////////////////////////////


            setPath();
        }
        private void setPath() {

            entryNode.setPath(0, A);
            entryNode.setPath(1, B);

            B.setPath(0, BA);
            B.setPath(1, BB);

            BA.setPath(0, BAA);
            BA.setPath(1, BAB);
            BA.setPath(2, BAC);
        }
        public EventNode getEntryNode(){
            return entryNode;
        }
    }
}
