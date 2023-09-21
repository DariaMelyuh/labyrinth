using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб1
{
    public class DoorWithTrap : Door
    {
        public DoorWithTrap(Room room1, Room room2) : base(room1, room2)
        { }

        public void Trap()
        {
            Console.WriteLine("Вас заперли!");
        }
    }
}