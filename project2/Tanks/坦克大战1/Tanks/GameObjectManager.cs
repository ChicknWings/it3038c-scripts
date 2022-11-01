using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tanks.Properties;

namespace Tanks
{
    class GameObjectManager
    {
        private static List<UnMovable> wallList = new List<UnMovable>();
        private static List<UnMovable> steelList = new List<UnMovable>();
        private static UnMovable boss;
        private static MyTank myTank;

        public static void Update() {

            foreach (UnMovable um in wallList)
            {
                um.Update();
            }
            foreach (UnMovable um in steelList)
            {
                um.Update();
            }
            boss.Update();

            myTank.Update();


        }

        //public static void DrawMap()
        //{
        //    foreach (UnMovable um in wallList) {
        //        um.DrawSelf();
        //    }
        //    foreach (UnMovable um in steelList)
        //    {
        //        um.DrawSelf();
        //    }
        //    boss.DrawSelf();

        //}
        //public static void DrawMyTank() {
        //    myTank.DrawSelf();

        //}



        public static void CreateMyTank() 
        {
            int x = 5 * 30;
            int y = 14 * 30;

            myTank = new MyTank(x, y, 2);
        }
        public static void CreatMap() 
        {
            CreatWall(1, 1, 5, Resources.wall, wallList);
            CreatWall(3, 1, 5, Resources.wall, wallList);
            CreatWall(5, 1, 4, Resources.wall, wallList);
            CreatWall(7, 1, 3, Resources.wall, wallList);
            CreatWall(9, 1, 4, Resources.wall, wallList);
            CreatWall(11, 1, 5, Resources.wall, wallList);
            CreatWall(13, 1, 5, Resources.wall, wallList);

            CreatWall(7, 5, 1, Resources.steel, steelList);
            CreatWall(0, 7, 1, Resources.steel, steelList);


            CreatWall(2, 7, 1, Resources.wall, wallList);
            CreatWall(3, 7, 1, Resources.wall, wallList);
            CreatWall(4, 7, 1, Resources.wall, wallList);
            CreatWall(6, 7, 1, Resources.wall, wallList);
            CreatWall(7, 6, 2, Resources.wall, wallList);
            CreatWall(8, 7, 1, Resources.wall, wallList);
            CreatWall(10, 7, 1, Resources.wall, wallList);
            CreatWall(11, 7, 1, Resources.wall, wallList);
            CreatWall(12, 7, 1, Resources.wall, wallList);

            CreatWall(14, 7, 1, Resources.steel, steelList);
            CreatWall(1, 9, 5, Resources.wall, wallList);
            CreatWall(3, 9, 5, Resources.wall, wallList);
            CreatWall(5, 9, 3, Resources.wall, wallList);
            CreatWall(6, 10, 1, Resources.wall, wallList);
            CreatWall(7, 10, 2, Resources.wall, wallList);
            CreatWall(8, 10, 1, Resources.wall, wallList);

            CreatWall(9, 9, 3, Resources.wall, wallList);

            CreatWall(11, 9, 5, Resources.wall, wallList);
            CreatWall(13, 9, 5, Resources.wall, wallList);

            CreatWall(6, 13, 2, Resources.wall, wallList);
            CreatWall(7, 13, 1, Resources.wall, wallList);
            CreatWall(8, 13, 2, Resources.wall, wallList);

            CreateBoss(7,14,Resources.Boss);
        }

        private static void CreateBoss(int x, int y, Image img) 
        {
            int xPosition = x * 30;
            int yPosition = y * 30;
            boss =new UnMovable(xPosition, yPosition, img);

        }

        private static void CreatWall(int x, int y,int count,Image img, List<UnMovable> wallList) 
        {
            int xPosition = x * 30;
            int yPosition = y * 30;
            for (int i = yPosition; i < yPosition + count * 30; i += 15)
            {
                UnMovable wall1 = new UnMovable(xPosition, i, img);
                UnMovable wall2 = new UnMovable(xPosition+15, i, img);
                wallList.Add(wall1);
                wallList.Add(wall2);
            }
        }

        public static void KeyDown(KeyEventArgs args)
        {

            myTank.KeyDown(args);

        }
        public static void KeyUp(KeyEventArgs args)
        {


            myTank.KeyUp(args);

        }
    }
}
