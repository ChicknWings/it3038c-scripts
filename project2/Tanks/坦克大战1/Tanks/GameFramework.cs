﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks
{
    class GameFramework
    {
        public static Graphics g;
        public static void Start()
        {
            GameObjectManager.CreatMap();
            GameObjectManager.CreateMyTank();

        }

        public static void Update()
        {
            //GameObjectManager.DrawMap();
            //GameObjectManager.DrawMyTank();
            GameObjectManager.Update();
        }





    }
}
