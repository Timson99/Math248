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
        Texture2D[] buttons;
        Texture2D thisButton;
        Vector2 position;
        int buttonNum;

        public PathButton(int buttonNum)
        {
            this.buttonNum = buttonNum;
            //Set 
        }
        public void Load()
        {
            //Load in Game
        }
        public void Update()
        {
            //Empty?
        }
        public void Draw()
        {
            //Call in GameManager
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
