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
    public class GameManager
    {
        SpriteFont gameFont;
        List<StillSprite> backgrounds = new List<StillSprite>();
        List<StillSprite> sprites = new List<StillSprite>();
        List<StillSprite> onscreen = new List<StillSprite>();
        Texture2D currentBackground;
        string currentText;
        EventNode mainMenu;
        EventNode currentNode;

        public GameManager()
        {
            //mainMenu = new EventNode();
            currentNode = mainMenu;
        }
        public void Load()
        {
            //Load Font
            gameFont = GameServices.Content.Load<SpriteFont>("Assets/gameFont");
            //Load All Backgrounds
            //Turn Backgrounds into StillSpite objects and place into backkgrounds List (List capacity is listName.Count)
            //Load All Sprites
            //Turn sprites into StillSpite objects and place into sprites List (List capacity is listName.Count)
        }
        //Fills currentBackround, onscreen, and currentText, based on values in the current event Node
        public void Update()
        {
            //Get Number of Buttons from currentEvent Node, Create Button Objects 
            
            //Get backround from current event
            //Take key values event tree 
            //When sprite found in list with matching key, .Add() to onscreen list
            //Get string from the current eventd       
        }
        public void Draw()
        {
            //Draw Backround
            //GameServices.spriteBatch.Draw(currentBackground, new Vector2(3, 3), Color.White);

            //Draw Sprites, Iterate though onscreen list (using listName.Count) and Draw 


            //Draw Font
            GameServices.spriteBatch.DrawString(gameFont, currentText, new Vector2(3,3), Color.White);
        }
    }
}
