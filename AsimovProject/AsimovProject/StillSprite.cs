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
    //Construct with Texture and Position
    //Drawn in GameManager from list
    //Set and Get onscreen value
    class StillSprite
    {
        private Texture2D sprite;
        private Vector2 position;
        public string key;

        public StillSprite(Texture2D sprite, Vector2 position, string key)
        {
            this.sprite = sprite;
            this.position = position;
            this.key = key;
        }
        public void Draw()
        {
            GameServices.spriteBatch.Draw(sprite, position, Color.White);
        }
    }
}
