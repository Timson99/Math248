using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;

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

        //Song Asset
        private Song happySong;
        private Song sadSong;
        bool wasSad = false;

        //Event Handling 
        EventNode mainMenu;
        EventNode characterSelect;
        EventNode currentNode; //Set equal to current node of chosen path
        Path1 path1 = new Path1();
        Path2 path2 = new Path2();

        //Button Info
        Vector2 buttonPos = new Vector2(100, 400);
        int buttonDelta = 400;
        bool mReleased = true;

        public GameManager()
        {
            List<string> temp = new List<string>();
            temp.Add("RoboHap");
            mainMenu = new EventNode("sky", temp, 1, "MY ROBOTIC ADVENTURES");
            temp.Clear();
            temp.Add("Vp");
            temp.Add("Quirk2");
            characterSelect = new EventNode("sky", temp, 2, "Choose Your Target!\n A: Captain Quirk\n B:Vice President \nof the United Federations");

            mainMenu.setPath(0, characterSelect);
            characterSelect.setPath(0, path1.getEntryNode());
            characterSelect.setPath(1, path2.getEntryNode());
            currentNode = mainMenu;

        }
       
        public void Load()
        {
            ///Loading///
   
            //Load Font(s)
            gameFont = GameServices.Content.Load<SpriteFont>("Assets/Fonts/gameFont");

            happySong = GameServices.Content.Load<Song>("Assets/Music/HappySong");
            sadSong = GameServices.Content.Load<Song>("Assets/Music/SadSong");
            MediaPlayer.Play(happySong);
            MediaPlayer.IsRepeating = true;
            

           


            //Load All Backgrounds into "backgrounds" Dictionary as StillSprites
            backgrounds["sky"]  = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/sky"), new Vector2(0,0));
            //backgrounds["space"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/spaceBackground"), new Vector2(0, 0));
            backgrounds["space2"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/space2"), new Vector2(0, 0));
            backgrounds["field"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/field"), new Vector2(0, 0));
            backgrounds["fieldRed"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/fieldRed"), new Vector2(0, 0));
            backgrounds["glowyGrass"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/glowyGrass"), new Vector2(0, 0));
            backgrounds["sunny"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/sunny"), new Vector2(0, 0));
            backgrounds["dino"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/wierd"), new Vector2(0, 0));
            backgrounds["mountain"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/mountain"), new Vector2(0, 0));
            backgrounds["win"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Backgrounds/win"), new Vector2(0, 0));


            //Load All Sprites into "sprites" Dictionary as StillSprites
            sprites["Vp"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/kim"), new Vector2(Game1.gameWidth-400, 0));
            sprites["VpCry"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/kimSad"), new Vector2(Game1.gameWidth - 400, 0));
            sprites["Pres"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/president"), new Vector2(Game1.gameWidth - 400 ,0));
            sprites["PresCry"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/presidentCry"), new Vector2(Game1.gameWidth - 400, 0));
            sprites["PresBlood"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/presidentBlood"), new Vector2(Game1.gameWidth - 400, 0));
            sprites["Quirk"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/kirk"), new Vector2(Game1.gameWidth - 390, 0));
            sprites["Quirk2"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/kirk"), new Vector2(0, 0));
            sprites["RoboHap"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/happyRobot"), new Vector2(-25, 0));
            sprites["RoboMad"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/angryRobot"), new Vector2(-25, 0));
            sprites["RoboSad"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/sadRobot"), new Vector2(-25, 0));
            sprites["RoboBloodySad"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/sadBloodyRobot"), new Vector2(-25, 0));
            sprites["RoboBlush"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/veryHappyRobot"), new Vector2(-25, 0));
            sprites["QuirkVomit"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/QuirkThrowUp"), new Vector2(Game1.gameWidth - 390, 0));
            sprites["QuirkCry"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/CryQuirk"), new Vector2(Game1.gameWidth - 390, 0));
            sprites["QuirkDead"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/DeadQuirk"), new Vector2(Game1.gameWidth - 390, 0));
            sprites["QuirkDeadNoBlood"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/QurikDeadNoBlood"), new Vector2(Game1.gameWidth - 390, 0));
            //sprites["backer"] = new StillSprite(GameServices.Content.Load<Texture2D>("Assets/Sprites/ButtonBacker"), new Vector2(0, 400));



        }
        public void Update()
        {
            buttons.Clear(); //Clears List for Repopulation
            onscreen.Clear(); //Clears List for Repopulation

            if (currentNode == null) //If null, assumes game is over and starts from the beginning
                currentNode = mainMenu;

            ////Input////
            buttons.Add(new PathButton(5, -1, new Vector2(1230, 0)));
            
            if (currentNode.Equals(mainMenu))
            {
                buttons.Add(new PathButton(3, 0, new Vector2(Game1.gameWidth / 2, Game1.gameHeight / 2)));
            }
            else
            {
                int maxButtons = currentNode.getNumButtons();
                if (maxButtons == 2) {
                    buttons.Add(new PathButton(0, 0, new Vector2(100,400)));
                    buttons.Add(new PathButton(1, 1, new Vector2(Game1.gameWidth-300,400)));
                } else if(maxButtons == 3) {
                    buttons.Add(new PathButton(0, 0, new Vector2(100, 400)));
                    buttons.Add(new PathButton(1, 1, new Vector2((Game1.gameWidth-200)/2, 400)));
                    buttons.Add(new PathButton(2, 2, new Vector2(Game1.gameWidth-300, 400)));
                }
                else
                {
                    buttons.Add(new PathButton(4, 0, new Vector2(Game1.gameWidth/2 - 100, 400)));
                }
            }

            MouseState mState = Mouse.GetState();

            for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i].getRectangle().Contains(mState.X, mState.Y))
                {
                    buttons[i].colored = true;
                }
                else
                {
                    buttons[i].colored = false;
                }
            }
            if (mState.LeftButton == ButtonState.Pressed && mReleased == true)
            {
                for(int i = 0; i < buttons.Count; i++)
                {
                    if(buttons[i].getRectangle().Contains(mState.X,mState.Y))
                    {
                        if (buttons[i].getButtonPath() == -1)
                            Environment.Exit(0);

                        currentNode = currentNode.nextNode(buttons[i].getButtonPath());
                    }
                }
                mReleased = false;
            }
            if(mState.LeftButton == ButtonState.Released)
            {
                mReleased = true;
            }

            if (currentNode == null) //If null, assumes game is over and starts from the beginning
                currentNode = mainMenu;


            if(currentNode.getBackgroundKey() == "fieldRed" && wasSad == false)
            {
                wasSad = true;
                TimeSpan temp = MediaPlayer.PlayPosition;
                double mSeconds = temp.Milliseconds + temp.Seconds * 1000 + temp.Minutes * 60000;
                mSeconds *= (1.0d/0.212209302d);
                temp = new TimeSpan(0, 0,(int)(mSeconds/60000), (int)(mSeconds / 1000), (int)(mSeconds % 1000));
                MediaPlayer.Play(sadSong, temp);

            }
            if(wasSad == true && currentNode.getBackgroundKey() != "fieldRed")
            {
                wasSad = false;
                TimeSpan temp = MediaPlayer.PlayPosition;
                double mSeconds = temp.Milliseconds + temp.Seconds * 1000 + temp.Minutes * 60000;
                mSeconds *= 0.212209302d;
                temp = new TimeSpan(0, 0, (int)(mSeconds / 60000), (int)(mSeconds / 1000), (int)(mSeconds % 1000));
                MediaPlayer.Play(happySong, temp);
            }


            currentBackground = backgrounds[currentNode.getBackgroundKey()]; 
            for (int i = 0; i < currentNode.getSpriteKeyList().Count; i++){
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
                onscreen[i].Draw();

            //sprites["backer"].color = Color.DarkRed;
            //sprites["backer"].Draw();
            //Iterate through button list and call PathButton.Draw() for each instance
            for (int i = 0; i < buttons.Count; i++)
                buttons[i].Draw();

            //Draw Font
            GameServices.spriteBatch.DrawString(gameFont, currentText, new Vector2(340,50), Color.White);
        }
    }
}
