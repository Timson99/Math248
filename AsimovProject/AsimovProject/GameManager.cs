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

        //Button Info
        Vector2 buttonPos = new Vector2(Game1.gameHeight / 4, Game1.gameWidth / 4);
        int buttonDelta = 200;
        bool mReleased = true;

        public GameManager()
        {
            mainMenu = new EventNode("space", new List<string>(), 2, "This is the main menu"); //No Background, Empty Sprite List, No Text, Two Paths
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
            backgrounds["space2"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/space2"), new Vector2(0, 0));
            currentBackground = backgrounds["space2"];
            //Load All Sprites into "sprites" Dictionary as StillSprites

            


        }
        public void Update()
        {
            buttons.Clear(); //Clears List for Repopulation
            onscreen.Clear(); //Clears List for Repopulation

            if (currentNode == null) //If null, assumes game is over and starts from the beginning
                currentNode = mainMenu;

            ////Input////
            if(currentNode.Equals(mainMenu))
            {
                buttons.Add(new PathButton(3, new Vector2(Game1.gameWidth / 2, Game1.gameHeight / 2)));
            }
            int tempNumButtons = currentNode.getNumButtons();
            for(int i = 0; i < tempNumButtons; i++)
            {
                buttons.Add(new PathButton(i, new Vector2(buttonPos.X + i*(buttonDelta), buttonPos.Y)));   
            }

            MouseState mState = Mouse.GetState();

            if (mState.LeftButton == ButtonState.Pressed && mReleased == true)
            {
                for(int i = 0; i < buttons.Count; i++)
                {
                    if(buttons[i].getRectangle().Contains(mState.X,mState.Y))
                    {
                        currentNode = currentNode.nextNode(buttons[i].getButtonNum());
                    }
                }
                mReleased = false;
            }
            if(mState.LeftButton == ButtonState.Released)
            {
                mReleased = true;
            }

                    
            currentBackground = backgrounds[currentNode.getBackgroundKey()]; 
            for (int i = 0; i < currentNode.getSpriteKeyList().Count(); i++){
                onscreen.Add(sprites[currentNode.getSpriteKeyList()[i]]); 
            }
            currentText = currentNode.getText();

            Console.WriteLine(currentNode.getBackgroundKey());


                     
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
