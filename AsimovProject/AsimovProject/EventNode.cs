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
    //Done
    class EventNode
    {
        private string backgroundKey;
        private List<string> spriteKeys;
        private string text;
        private int numButtons;
        private EventNode[] paths;

        public EventNode(string backgroundKey, List<string> spriteKeys, int numPaths, string text)
        {
            this.backgroundKey = backgroundKey;

            this.spriteKeys = new List<string>();
            if (spriteKeys != null)
            {
                for (int i = 0; i < spriteKeys.Count; i++)
                {
                    this.spriteKeys.Add(spriteKeys[i]);
                }
            }
            this.text = text;
            numButtons = numPaths;
            paths = new EventNode[numButtons];
        }

        public string getBackgroundKey()
        {
            return backgroundKey;
        }

        public List<string> getSpriteKeyList()
        {
            return spriteKeys;
        }

        public string getText()
        {
            return text;
        }

        //Use in Path1.cs and Path2.cs to create trees
        public void setPath(int pathNumber, EventNode eN)
        {
            paths[pathNumber] = eN;
        }

        public int getNumButtons()
        {
            return numButtons;
        }

        //Use in GameManager to Move through the Game
        public EventNode nextNode(int path)
        {
            return paths[path];
        }

    }
}
