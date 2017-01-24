using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Battleship_tsjeer
{
    class Ship
    {
        Texture2D tex;
        Vector2 pos;
        bool rotated;
        public Ship(Texture2D tex, Vector2 pos, bool rotated)
        {
            this.tex = tex;
            this.pos = pos;
            this.rotated = rotated;
        }

        public void Draw(SpriteBatch sp)
        {
            float rotation = 0;
            if (rotated)
                rotation = (float)Math.PI / 2.0f;

            sp.Draw(tex,pos,new Rectangle(0,0,100,50), Color.Red, rotation, Vector2.Zero,1, SpriteEffects.None,0);
        }
    }
}
