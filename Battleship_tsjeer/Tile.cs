using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Battleship_tsjeer
{
    class Tile
    {
        Texture2D tex;
        Vector2 pos;
        bool rotated;
        Ship ship = null;

        public Tile(Texture2D tex, Vector2 pos, bool rotated)
        {
            this.tex = tex;
            this.pos = pos;
            this.rotated = rotated;
        }

        public void Draw(SpriteBatch sp)
        {
            if(ship!=null)
                sp.Draw(tex, pos, Color.Blue);
        }

        public void SetShip(Ship ship)
        {
            this.ship = ship;
        }
    }

    
}
