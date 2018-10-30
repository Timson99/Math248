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
    //Class that takes a button num and sets corresponding button in array to this button.
    //
    class PathButton
    {
        private Texture2D[] buttons;
        private Texture2D thisButton;
        private Vector2 position;
        private int buttonNum;

        public PathButton(int buttonNum)
        {
            this.buttonNum = buttonNum;
            //Fill thisbutton field
            //Determine Position Internally or Externally?
        }
        public void Load()
        {
            //Load in Game Load method
        }
        public void Draw()
        {
            //Call in GameManager Draw method
        }
        public Vector2 getPosition()
        {
            return position;
        }
        public int getButtonNum()
        {
            return buttonNum;
        }
    }
}
