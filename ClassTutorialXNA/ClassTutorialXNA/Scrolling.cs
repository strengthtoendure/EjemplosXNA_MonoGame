﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTutorialXNA
{
    class Scrolling : Background
    {
        public Scrolling(Texture2D newTexture, Rectangle newRectange, Color newColor)
        {
            texture = newTexture;
            rectangle = newRectange;
            color = newColor;
        }

        public new void Update()
        {
            //if (Keyboard.GetState().IsKeyDown(Keys.Right))
            //    rectangle.X -= 3;

            //if (Keyboard.GetState().IsKeyDown(Keys.Left))
            //    rectangle.X += 3;

            //rectangle.X -= 3;

        }

    }
}
