using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks
{
    abstract class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; }
        public int Heigt { get; set; }
        protected abstract Image GetImage();

        public void DrawSelf() 
        {
            Graphics g = GameFramework.g;

            g.DrawImage(GetImage(),X,Y);
        
        }

        public virtual void Update() {
            DrawSelf();
        
        }
    }
}
