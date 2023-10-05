using Library;
using Лаб1;

namespace Лаб2
{
    public class MazeBuilderWithTrap : MazeBuilder
    {
        protected override Door CreaateDoor(Room room1, Room room2)
        {
            return new DoorWithTrap(room1, room2);
        }
        
        protected override Room CreaateRoom(int number)
        {
            return new  RoomWithTrap(number);
        }
    }
}
