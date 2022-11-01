using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    enum Direction { 
        Up,
        Down,
        Left,
        Right
    }
    class Movable:GameObject
    {
        public Bitmap BitmapUp { get; set; }
        public Bitmap BitmapDown { get; set; }
        public Bitmap BitmapLeft { get; set; }
        public Bitmap BitmapRight { get; set; }

        public int speed { get; set; }

        private Direction dir;
        public Direction Dir { get { return dir; } 

            set {
                dir = value;
                Bitmap bmp = null;
                switch (dir) 
                {
                    case Direction.Up:
                        bmp = BitmapUp;
                        break;
                    case Direction.Down:
                        bmp = BitmapDown;
                        break;
                    case Direction.Left:
                        bmp = BitmapLeft;
                        break;
                    case Direction.Right:
                        bmp = BitmapRight;
                        break;
                }

                Width = bmp.Width;
                Heigt = bmp.Height;
            } 
        }

        protected override Image GetImage()
        {
            Bitmap bitmap = null;
            switch (Dir)
            {
                case Direction.Up:
                    return BitmapUp;
                case Direction.Down:
                    return BitmapDown;
                case Direction.Left:
                    return BitmapLeft;
                case Direction.Right:
                    return BitmapRight;
            }
            bitmap.MakeTransparent(Color.Black);

            return BitmapUp;
        }
    }
}
