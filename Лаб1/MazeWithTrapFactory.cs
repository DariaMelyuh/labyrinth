using Library;
namespace Лаб1
{
    public class MazeWithTrapFactory : MazeFactory
    {
        public override Door CreateDoor(Room _room1, Room _room2)
        {
            return new DoorWithTrap(_room1, _room2);
        }

        public override Room CreateRoom(int Number)
        {
            return new RoomWithTrap(Number);
        }
    }
}
