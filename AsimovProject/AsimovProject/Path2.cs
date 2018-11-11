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
            entryNode = new EventNode("space2", temp, 2, "This is the beginning of Path2");
            temp.Clear();


            ////////////// for A 
            temp.Add("RoboMad");
            temp.Add("Pres");
            A = new EventNode("space2", temp, 3, "for decision A");
            temp.Clear();
            
            /////////////
            ////// for B 
            B = new EventNode("space2", temp, 1, "Say no: GAME OVER");
            temp.Clear();

            //////
            ////// for AA
            temp.Add("Vp");
            AA = new EventNode("space2", temp, 2, "for decision B");
            temp.Clear();

            //////
            ////// for AB 
            AB = new EventNode("space2", temp, 3, "for decision B");
            temp.Clear();

            //////
            ////// for AC 
            AC = new EventNode("space2", temp, 3, "for decision B");
            temp.Clear();

            //////
            ////// for AAA
            AAA = new EventNode("space2", temp, 1, "for decision B");
            temp.Clear();

            ////
            ////// for AAB 
            AAB = new EventNode("space2", temp, 1, "for decision B");
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
