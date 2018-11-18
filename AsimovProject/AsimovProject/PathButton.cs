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
    public class PathButton
    {
        private static Texture2D[] buttons;
        private Rectangle rect;
        private Texture2D thisButton;
        private Vector2 position;
        private int buttonTex;
        private int buttonPath; //Path index followed by button
        public bool colored = false;

        public PathButton(int buttonTex, int buttonPath, Vector2 position)
        {
            this.buttonTex = buttonTex;
            this.buttonPath = buttonPath;
            this.position = position;
            thisButton = buttons[buttonTex];

            if(buttonTex == 3 || buttonTex == 4)
            {
                rect = new Rectangle((int)position.X, (int)position.Y, 300, 150);
            }
            else if(buttonTex == 5)
            {
                rect = new Rectangle((int)position.X, (int)position.Y, 50, 50);
            }
            else
            {
                rect = new Rectangle((int)position.X, (int)position.Y, 200, 200);
            }
        }
        public static void Load()
        {
            buttons = new Texture2D[6];
            buttons[0] = GameServices.Content.Load<Texture2D>("Assets/Buttons/buttA");
            buttons[1] = GameServices.Content.Load<Texture2D>("Assets/Buttons/buttB");
            buttons[2] = GameServices.Content.Load<Texture2D>("Assets/Buttons/buttC");
            buttons[3] = GameServices.Content.Load<Texture2D>("Assets/Buttons/buttStart");
            buttons[4] = GameServices.Content.Load<Texture2D>("Assets/Buttons/buttRestart");
            buttons[5] = GameServices.Content.Load<Texture2D>("Assets/Buttons/xButt");
        }
        public void Draw()
        {
            GameServices.spriteBatch.Draw(thisButton, position, (colored ? Color.CornflowerBlue: Color.White));
        }
        public Vector2 getPosition()
        {
            return position;
        }
        public int getButtonPath()
        {
            return buttonPath;
        }

        public Rectangle getRectangle()
        {
            return rect;
        }
    }
}
