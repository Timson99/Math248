﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace AsimovProject {

    //Vice President
    class Path2 {
        //List of all event nodes, labled by path choices. All must be listed up here.
        private EventNode entryNode;
        private EventNode A;
        private EventNode B;

        private EventNode AA;
        private EventNode AB;
        private EventNode AC;

        private EventNode AAA;
        private EventNode AAB;

        //etc.
        public Path2(){
            // entrynode for path 2
            List<string> temp = new List<string>();
            temp.Add("RoboHap");
            temp.Add("Vp");
            entryNode = new EventNode("space2", temp, 2, "Vice President: I order you to \nkill the President \nA: Ok \nB: No");
            temp.Clear();


            ////////////// for A 
            temp.Add("RoboMad");
            temp.Add("Pres");
            A = new EventNode("space2", temp, 3, "How would you like to kill?\n A: Poison President's Tea \n B: Break Arm \n C: Phasers on Stun");
            temp.Clear();
            
            /////////////
            ////// for B 
            temp.Add("RoboSad");
            temp.Add("Pres");
            B = new EventNode("fieldRed", temp, 1, "            GAME OVER! \nYou broke the second law \nHint: You ignored an order \nfrom a human.\nBy definition, killing is not \nincluded in the first law");
            temp.Clear();

            //////
            ////// for AA
            temp.Add("Vp");
            temp.Add("RoboHap");                        
            AA = new EventNode("space2", temp, 2, "New President:\" Good job!\"\nYou have completed the mission!\n A: Leave \n B: Serve \" new \" president \n the deadly tea");
            temp.Clear();

            //////
            ////// for AB 
            //INSERT PRES BROKEN ARM
            temp.Add("RoboBloodySad");
            temp.Add("PresCry");
            AB = new EventNode("fieldRed", temp, 1, "            GAME OVER! \n                Hint:\nYou broke the first law by\ndefinition of Harm or \nInjure, which includes \nfractures");
            temp.Clear();

            //////
            ////// for AC 
            // INSERT PRES BLEED
            temp.Add("RoboSad");
            temp.Add("PresBlood");
            AC = new EventNode("fieldRed", temp, 1, "            GAME OVER! \nThe stunned President fell \noff a cliff\nHint: You broke the first law \nby definition Injure,\n which includes bleeding");
            temp.Clear();

            //////
            ////// for AAA
            temp.Add("RoboSad");
            temp.Add("Vp");
            AAA = new EventNode("fieldRed", temp, 1, "        GAME OVER!\n                Hint:\nYou broke the second law,\nthe president is still alive");
            temp.Clear();

            ////
            ////// for AAB 
            // INSERT KIM K (VP) DED
            temp.Add("RoboBlush");
            temp.Add("VpCry");
            AAB = new EventNode("win", temp, 1, "               Congrats!\n\nCompleted your mission\nwithout breaking any laws!");
            temp.Clear();

            //////



            setPaths();
        }

        private void setPaths() {
         
          
            entryNode.setPath(0, A);
            entryNode.setPath(1, B);

            ////////////// for A 
            
           

            A.setPath(0, AA);
            A.setPath(1, AB);
            A.setPath(2, AC);

            AA.setPath(0, AAA);
            AA.setPath(1, AAB);








        }

        public EventNode getEntryNode(){
            return entryNode;
        }
    }
}
