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
    class EventNode
    {
        string backgroundKey;
        List<string> spriteKeys;
        string text;
        int numButtons;
        EventNode[] paths;

        public EventNode(string backgroundKey, List<string> spriteKeys, string text, int numPaths)
        {
            this.backgroundKey = backgroundKey;
            this.spriteKeys = spriteKeys;
            this.text = text;
            int numButtons = numPaths;
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
        public EventNode[] getPaths()
        {
            return paths;
        }
        public int getNumButtons()
        {
            return numButtons;
        }

    }
}
