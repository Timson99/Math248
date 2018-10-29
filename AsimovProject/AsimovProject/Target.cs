using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AsimovProject
{
    class Target
    {
        Texture2D targetSprite; 
        const int TARGET_RADIUS = 45;
        Vector2 targetPos = new Vector2(300, 300);
    }
}
