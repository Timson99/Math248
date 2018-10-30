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
        private SpriteFont gameFont;
        private List<PathButton> buttons = new List<PathButton>(); //Make into a Dictionary
        private Dictionary<string, StillSprite> backgrounds = new Dictionary<string, StillSprite>(); //backgounds["blue"] = new StillSprite(...)
        private Dictionary<string, StillSprite> sprites = new Dictionary<string, StillSprite>();
        private List<StillSprite> onscreen = new List<StillSprite>();
        private Texture2D currentBackground;
        private string currentText;

        
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
         
            gameFont = GameServices.Content.Load<SpriteFont>("Assets/gameFont");
            //Load All Backgrounds
            //Load All Sprites

            ///Fill field lists///
            //Turn Backgrounds into StillSpite objects and place into backkgrounds Dictionary (Dictionary capacity is listName.Count)
            //Turn sprites into StillSpite objects and place into sprites Dictionary (Dictionary capacity is listName.Count)
        }

        public void Update()
        {
            //if chosen path is null, currentNode is mainMenu

            ////Input////
                //Get Number of Buttons from currentEvent Node, Create Button Objects 
                        //Use MouseState mState = Mouse.getState
                        //Has X and Y fields and LeftButton field
                        //Check for input with mState.LeftButton == ButtonState.Pressed
                        //Make sure input is only registed once (Holding button down register as more than a single input)
                //When input detected, check position of a buttons in list with position of mouse
                //If mouse is within the area of the button when input is registered, record input. 
                //Call nextNode() from currentNode
                //set currentNode equal to the new currentNode (returned by nextNode())
            

            ////Get Current Event Keys////
                //Get backround from current event
                //Take key values event tree 
                //When sprite found in list with matching key, .Add() to onscreen list
                //Get text string from the current event and set to text field.       
        }
        public void Draw()
        {

            //Draw Backround
            //GameServices.spriteBatch.Draw(currentBackground, new Vector2(3, 3), Color.White);

            //Draw Sprites with loop, Iterate though onscreen list (using listName.Count) and Draw 


            //Draw Font
            //GameServices.spriteBatch.DrawString(gameFont, currentText, new Vector2(3,3), Color.White);
        }
    }
}
