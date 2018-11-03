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
    //Done besides loading
    class PathButton
    {
        private static Texture2D[] buttons;
        private Rectangle rect;
        private Texture2D thisButton;
        private Vector2 position;
        private int buttonNum;

        public PathButton(int buttonNum, Vector2 position)
        {
            this.buttonNum = buttonNum;
            this.position = position;
            thisButton = buttons[buttonNum];

            if(buttons.Length == 3)
            {
                rect = new Rectangle((int)position.X, (int)position.Y, 100, 100);
            }
            else
            {
                rect = new Rectangle((int)position.X, (int)position.Y, 100, 100);
            }
        }
        public static void Load()
        {
            buttons = new Texture2D[4];
            buttons[0] = GameServices.Content.Load<Texture2D>("Assets/Buttons/buttA");
            buttons[1] = GameServices.Content.Load<Texture2D>("Assets/Buttons/buttB");
            buttons[2] = GameServices.Content.Load<Texture2D>("Assets/Buttons/buttC");
            buttons[3] = GameServices.Content.Load<Texture2D>("Assets/Buttons/buttStart");
        }
        public void Draw()
        {
            GameServices.spriteBatch.Draw(thisButton, position, Color.White);
        }
        public Vector2 getPosition()
        {
            return position;
        }
        public int getButtonNum()
        {
            return buttonNum;
        }

        public Rectangle getRectangle()
        {
            return rect;
        }
    }
}
