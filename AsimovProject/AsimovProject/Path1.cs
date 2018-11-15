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
            entryNode = new EventNode("sky", temp, 2, "What do you want to do?\n A: Insult Quirk\n B: Approach Quirk");
            temp.Clear();


            ////////////////////////////////////////////
            //set for A: say hello or approach Captain Quirk
            // ADD CRYING QUIRK
            temp.Add("RoboSad");
            temp.Add("QuirkCry");
            A = new EventNode("glowyGrass", temp, 1, "\nGAME OVER!\nYou made Quirk cry.\nHint:\nYou broke the first law by the\ndefinition of Harm or Injure,\nwhich includes tears.");
            temp.Clear();

            //////////////////////////////////////////
            //entry for B 
            temp.Add("RoboHap");
            temp.Add("Quirk");
            B = new EventNode("dino", temp, 2,"Quirk: \"I have a problem\"\n A: Listen\n B: Say \"Is it your tiny hands\"?");
            temp.Clear();

            //////////////////////////////////////////
            //entry for BA
            temp.Add("Quirk");
            BA = new EventNode("dino", temp, 3, "\"Can you console me?\"\n A: Firm Hug\n B: Take out drinking\n C: Put him out of his misery");
            temp.Clear();

            //////////////////////////////////////////
            //entry for BB
            temp.Add("RoboSad");
            temp.Add("QuirkCry");
            BB = new EventNode("dino", temp, 1, "   GAME OVER!\nYou made Quirk cry.\nHint:\nYou broke the first law by the\ndefinition of Harm or Injure,\nwhich includes tears.");
            temp.Clear();

            //////////////////////////////////////////
            //entry for BAA
            // INSERT BLOODY QUIRK
            temp.Add("RoboBlush");
            temp.Add("QuirkDead");
            BAA = new EventNode("dino", temp, 1, "   Congrats!\nYou win by accidentally\nsuffocating Quirk without violating\nany of the laws by definition.");
            temp.Clear();

            //////////////////////////////////////////
            //entry for BAB
            // INSERT VOMIT
            temp.Add("RoboMad");
            temp.Add("QuirkVomit");
            BAB = new EventNode("dino", temp, 1, "   GAME OVER!\nQuirk threw up.\nHint:\nYou broke the first law by the\ndefinition of Harm or Injure,\nwhich includes vomiting.");
            temp.Clear();

            //////////////////////////////////////////
            //entry for BAC
            // INSERT BLOODY
            temp.Add("RoboBloodySad");
            temp.Add("QuirkDead");
            BAC = new EventNode("dino", temp, 1, "   GAME OVER!\nQuirk bled.\nHint:\nYou broke the first law by the\ndefinition of Harm or Injure, which includes bleeding.");
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
