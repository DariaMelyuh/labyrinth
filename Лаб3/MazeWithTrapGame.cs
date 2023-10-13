using Library;
using Лаб1;
namespace Лаб3
{
    public class MazeWithTrapGame : MazeGame
    {
        protected override Room CreateRoom(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Number не может быть отрицательным.");
            }
            return new RoomWithTrap(number);
        }
        
        protected override Door CreateDoor(Room room1, Room room2)
        {
            ArgumentNullException.ThrowIfNull(room1);
            ArgumentNullException.ThrowIfNull(room2);
            return new DoorWithTrap(room1, room2);
        }
    }
}
