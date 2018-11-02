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
        //Holds all Background and Sprite Assets
        private Dictionary<string, StillSprite> backgrounds = new Dictionary<string, StillSprite>(); //backgounds["blue"] = new StillSprite(...)
        private Dictionary<string, StillSprite> sprites = new Dictionary<string, StillSprite>();

        //Drawn Assets
        private List<PathButton> buttons = new List<PathButton>();
        private List<StillSprite> onscreen = new List<StillSprite>();
        private StillSprite currentBackground;
        private SpriteFont gameFont;
        private string currentText = "";

        //Event Handling 
        EventNode mainMenu;
        EventNode currentNode; //Set equal to current node of chosen path
        Path1 path1 = new Path1();
        Path2 path2 = new Path2();

        public GameManager()
        {
            mainMenu = new EventNode("", new List<string>(), "", 2); //No Background, Empty Sprite List, No Text, Two Paths
            mainMenu.setPath(0, path1.getEntryNode());
            mainMenu.setPath(1, path2.getEntryNode());
            currentNode = mainMenu;

        }
        public void Load()
        {
            ///Loading///
   
            //Load Font(s)
            gameFont = GameServices.Content.Load<SpriteFont>("Assets/Fonts/gameFont");

            //Load All Backgrounds into "backgrounds" Dictionary as StillSprites
            backgrounds["sky"]  = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/sky"), new Vector2(0,0));
            backgrounds["space"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/spaceBackground"), new Vector2(0, 0));

            //Load All Sprites into "sprites" Dictionary as StillSprites

            


        }
        public void Update()
        {
            buttons.Clear(); //Clears List for Repopulation
            onscreen.Clear(); //Clears List for Repopulation

            if (currentNode == null) //If null, assumes game is over and starts from the beginning
                currentNode = mainMenu; 

            ////Input////
                //Get Number of Buttons needed from currentEvent EventNode, Create that amount of PathButton Objects, add them to the button list
                        //Use MouseState mState = Mouse.getState (Has X and Y fields and LeftButton field)
                        //Check if mouse is over button, get each buttons Rectangle (Look up under Microsoft.Xna.Framework.Graphics.Texture2D))
                        // and call .Contains() [I think] to check if the rectangle contins the mouses position
                        //If mouse is in a buttons rectangle, Check for input with mState.LeftButton == ButtonState.Pressed
                        //Make sure input is only registed once (Use a mouseRelease Variable that tracks if the mouse was not pressed in the last frame)
                //If input registered on a button, Call nextNode() from currentNode using buttonNum of the pressed button
                //Set currentNode equal to the new currentNode (returned by nextNode())
            

            ////Use info from currentEvent to populate the Drawn Fields////
                //Get backround key from current event, use with backgrounds list to set currentBackground
                //Get the list of sprite keys from the currentNode, and access the StillSprite dictionary 
                //putting each sprite key in the sprites dictionaty into the onscreen using .Add()
                //Get text string from the current event and set to currentText field.       
        }
        public void Draw()
        {
            //Draw Backround
            if(currentBackground != null)
                currentBackground.Draw();

            //Draw Sprites with loop, Iterate though onscreen list (using listName.Count) and call .Draw from StillSprite
            for(int i = 0; i < onscreen.Count; i++)
            {
                onscreen[i].Draw();
            }

            //Iterate through button list and call PathButton.Draw() for each instance
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Draw();
            }

            //Draw Font
            GameServices.spriteBatch.DrawString(gameFont, currentText, new Vector2(3,3), Color.White);
        }
    }
}
