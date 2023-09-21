using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб1
{
    public class RoomWithTrap : Room
    {
        private DoorWithTrap trapDoor;
        private readonly Room room1;
        private readonly Room room2;

        public RoomWithTrap(int roomNo) : base(roomNo)
        {
            room1 = new Room(1);
            room2 = new Room(2);

            trapDoor = new DoorWithTrap(room1, room2);
        }

        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Вы попали в ловушку!");
            trapDoor.Trap();
        }
    }
}
