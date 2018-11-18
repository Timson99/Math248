using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

//Done
namespace AsimovProject
{
    //Construct with Texture and Position
    //Drawn in GameManager from list
    //Set and Get onscreen value
    class StillSprite
    {
        private Texture2D sprite;
        private Vector2 position;
        public Color color = Color.White;

        public StillSprite(Texture2D sprite, Vector2 position)
        {
            this.sprite = sprite;
            this.position = position;
        }
        public void Draw()
        {
            GameServices.spriteBatch.Draw(sprite, position, color);
        }
    }
}
