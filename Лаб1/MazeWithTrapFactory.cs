using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб1
{
    public class MazeWithTrapFactory : MazeFactory
    {
        public override Door CreateDoor(Room room1, Room room2)
        {
            return new DoorWithTrap(room1, room2);
        }

        public override Room CreateRoom(int roomNumber)
        {
            return new RoomWithTrap(roomNumber);
        }
    }
}
