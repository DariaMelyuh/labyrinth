using Library;
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
