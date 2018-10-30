﻿using System;
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
        private SpriteFont gameFont;
        private List<PathButton> buttons = new List<PathButton>(); //Make into a Dictionary
        private Dictionary<string, StillSprite> backgrounds = new Dictionary<string, StillSprite>(); //backgounds["blue"] = new StillSprite(...)
        private Dictionary<string, StillSprite> sprites = new Dictionary<string, StillSprite>();
        private List<StillSprite> onscreen = new List<StillSprite>();
        private StillSprite currentBackground;
        private string currentText = "";

        
        EventNode mainMenu;
        EventNode currentNode; //Set equal to current node of chosen path
        Path1 path1 = new Path1();
        Path2 path2 = new Path2();

        public GameManager()
        {
            mainMenu = new EventNode("", new List<string>(), "", 1);
            currentNode = mainMenu;
            //mainMenu setPath to Path1 and Path2 entryNodes
        }
        public void Load()
        {
            ///Loading///
   
            //Load Font(s)
            gameFont = GameServices.Content.Load<SpriteFont>("Assets/Fonts/gameFont");

            //Load All Backgrounds
            backgrounds["sky"]  = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/sky"), new Vector2(0,0));
            backgrounds["space"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/spaceBackground"), new Vector2(0, 0));
            currentBackground = backgrounds["space"];
            //Load All Sprites

            ///Fill field lists SET KEY VALUES///
            //Turn Backgrounds into StillSpite objects and place into backkgrounds Dictionary (Dictionary capacity is listName.Count)



            //Turn sprites into StillSpite objects and place into sprites Dictionary (Dictionary capacity is listName.Count)
        }

        public void Update()
        {
            //if currentNode is null, currentNode is mainMenu

            ////Input////
                //Get Number of Buttons from currentEvent EventNode, Create Button Objects 
                        //Use MouseState mState = Mouse.getState
                        //Has X and Y fields and LeftButton field
                        //Use X Y fields of mState and X Y fields of each button's getPosition()
                        // to check if the mouse is hovering over the button
                        //If it is Check for input with mState.LeftButton == ButtonState.Pressed
                        //Make sure input is only registed once (Holding button down register as more than a single input)
                //Call nextNode() from currentNode using buttonNum of the pressed button
                //set currentNode equal to the new currentNode (returned by nextNode())
            

            ////Get Current Event Keys////
                //Get backround key from current event, use with backgrounds list to set currentBackground
                //Get the list of sprite keys and iterate though it, 
                //Put each sprite key into sprites dictionaty, .Add() the result to onscreen list
                //Get text string from the current event and set to text field.       
        }
        public void Draw()
        {

            //Draw Backround
            currentBackground.Draw();

            //Draw Sprites with loop, Iterate though onscreen list (using listName.Count) and call .Draw from StillSprite


            //Draw Font
            GameServices.spriteBatch.DrawString(gameFont, currentText, new Vector2(3,3), Color.White);
        }
    }
}
