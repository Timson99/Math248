﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AsimovProject
{
    public class AnimatedSprite
    {
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;
        private double speed;
        private double timer;

        //Speed is total timer between each frame change
        public AnimatedSprite(Texture2D texture, int rows, int columns, double speed)
        {
            Texture = texture;
            Rows = rows;
            Columns = columns;
            currentFrame = 0;
            totalFrames = Rows * Columns;
            this.speed = speed;
            timer = speed;
        }

        public void Update()
        {
            timer -= GameServices.dt;
            if (timer <= 0) { 
                currentFrame++;
                timer = speed;
            }
            if (currentFrame == totalFrames)
                currentFrame = 0;
        }

        public void setCurrentFrame(int currentFrame)
        {
            this.currentFrame = currentFrame;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)location.X, (int)location.Y, width, height);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }
    }
}
