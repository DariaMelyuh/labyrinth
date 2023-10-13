using Library;
using Лаб1;

namespace Лаб2
{
    public class MazeBuilderWithTrap : MazeBuilder
    {
        protected override Door CreaateDoor(Room room1, Room room2)
        {
            ArgumentNullException.ThrowIfNull(room1);
            ArgumentNullException.ThrowIfNull(room2);
            return new DoorWithTrap(room1, room2);
        }
        
        protected override Room CreaateRoom(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Number не может быть отрицательным.");
            }
            return new  RoomWithTrap(number);
        }
    }
}
