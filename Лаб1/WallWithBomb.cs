using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
