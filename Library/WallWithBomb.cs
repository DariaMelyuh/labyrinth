﻿using System;
using Library;
namespace Лаб1
{
    public class WallWithBomb : Wall
    {
        private bool isExploded = false;

        public void Explode()
        {
            if (!isExploded)
            {
                Console.WriteLine("Стены разрушены!");
                isExploded = true;
               
            }
            
        }
        public override void Enter()
        {
           if (isExploded)
           {
                Console.WriteLine("Вы встретили разрушенную стену");
           }
           else
           {
              base.Enter();
           }
        }

    }
}