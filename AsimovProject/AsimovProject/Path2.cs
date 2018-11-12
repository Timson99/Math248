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
            A = new EventNode("space2", temp, 3, "How would you like to kill?\n A: Posion Presidents Tea \n B: Break Arm \n C: Phasers on Stun");
            temp.Clear();
            
            /////////////
            ////// for B 
            temp.Add("RoboSad");            
            B = new EventNode("space2", temp, 1, "GAME OVER! \nYou broke the second law \nHint:\n By definition, killing is not \n included in the first law");
            temp.Clear();

            //////
            ////// for AA
            temp.Add("Vp");
            temp.Add("RoboHap");                        
            AA = new EventNode("space2", temp, 2, "New President:\" Good job you have\n completed your mission!! \n A: Leave \n B: Serve \" new \" president the deadly tea");
            temp.Clear();

            //////
            ////// for AB 
            //INSERT PRES BROKEN ARM
            temp.Add("RoboSad");
            AB = new EventNode("space2", temp, 1, "GAME OVER! \nHint:\nYou broke the first law by the\ndefinition of Harm or Injure,\nwhich includes fractures");
            temp.Clear();

            //////
            ////// for AC 
            // INSERT PRES BLEED
            temp.Add("RoboSad");
            AC = new EventNode("space2", temp, 1, "GAME OVER! \nHint:\nYou broke the first law by the\ndefinition of Harm or Injure,\nwhich includes bleeding");
            temp.Clear();

            //////
            ////// for AAA
            temp.Add("RoboSad");
            temp.Add("Vp");
            AAA = new EventNode("space2", temp, 1, "GAME OVER!\nHint:\nYou broke the second law,\nthe president is still alive");
            temp.Clear();

            ////
            ////// for AAB 
            // INSERT KIM K (VP) DED
            temp.Add("RoboHap");
            AAB = new EventNode("space2", temp, 1, "Congrats!\nCompleted your mission without\n breaking any laws!");
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
