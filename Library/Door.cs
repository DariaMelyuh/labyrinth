using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Door : IMapSite
    {
        private readonly Room room1;
        private readonly Room room2;
        private readonly bool isOpen;

        public Door(Room room1, Room room2)
        {
            this.room1 = room1;
            this.room2 = room2;
            isOpen = true;
        }

        public void Enter()
        {
            if (isOpen)
            {
                Console.WriteLine("Дверь открыта, Вы проходите через дверь");
            }
            else
            {
                Console.WriteLine("Дверь закрыта, Вы не можете пройти.");
            }
        }
    }
}
