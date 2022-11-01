using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Tanks.Properties;

namespace Tanks
{
    class MyTank : Movable
    {
        public bool IsMoving { get; set; }
        public MyTank(int x, int y, int speed)
        {
            IsMoving = false;
            this.X = x;
            this.Y = y;
            this.speed = speed;
            BitmapDown = Resources.MyTankDown;
            BitmapUp = Resources.MyTankUp;
            BitmapLeft = Resources.MyTankLeft;
            BitmapRight = Resources.MyTankRight;
            this.Dir = Direction.Up;

        }
        public void KeyDown(KeyEventArgs args)
        {
            switch (args.KeyCode)
            {
                case Keys.W:
                    Dir = Direction.Up;
                    IsMoving = true;
                    break;
                case Keys.S:
                    Dir = Direction.Down;
                    IsMoving = true;
                    break;
                case Keys.A:
                    Dir = Direction.Left;
                    IsMoving = true;
                    break;
                case Keys.D:
                    Dir = Direction.Right;
                    IsMoving = true;
                    break;
            }


        }
        public void KeyUp(KeyEventArgs args)
        {
            switch (args.KeyCode)
            {
                case Keys.W:
                    IsMoving = false;
                    break;
                case Keys.S:
                    IsMoving = false;
                    break;
                case Keys.A:
                    IsMoving = false;
                    break;
                case Keys.D:
                    IsMoving = false;
                    break;
            }
        }
        private void Move() {

            if (IsMoving == false) return;

            switch (Dir) {
                case Direction.Up:
                    Y -= speed;
                    break;
                case Direction.Down:
                    Y += speed;
                    break;
                case Direction.Left:
                    X -= speed;
                    break;
                case Direction.Right:
                    X += speed;
                    break;

            }

        
        }
        public override void Update()
        {
            MoveCheck();
            Move();
            base.Update();
        }

        private void MoveCheck()
        {
            if (Dir == Direction.Up) {
                if (Y - speed < 0)
                {

                    IsMoving = false; return;
                }
                else if (Dir == Direction.Down) {
                    if (Y + speed + Heigt > 450) {

                        IsMoving = false; return;
                    }
                }
                else if (Dir == Direction.Left)
                {
                    if (X - speed <0 )
                    {

                        IsMoving = false; return;
                    }
                }
                else if (Dir == Direction.Right)
                {
                    if (X + speed+Width > 450)
                    {

                        IsMoving = false; return;
                    }
                }


            }
        
        
        }
    }
}
