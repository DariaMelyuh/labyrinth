using Library;
using Лаб1;

namespace Лаб2
{
    public class MazeBuilderWithTrap : MazeBuilder
    {
        public override Room BuildRoom(int Number)
        {
            RoomWithTrap room = new RoomWithTrap(Number);
            Maze.AddRoom(room);

            room.SetSide(Direction.North, new Wall());
            room.SetSide(Direction.South, new Wall());
            room.SetSide(Direction.West, new Wall());
            room.SetSide(Direction.East, new Wall());

            return room;
        }
        public override Door BuildDoor(int room1, int room2)
        {
            Room _room1 = Maze.RoomNo(room1);
            Room _room2 = Maze.RoomNo(room2);

            DoorWithTrap door = new DoorWithTrap(_room1, _room2);

            _room1.SetSide(Direction.East, door);
            _room2.SetSide(Direction.West, door);

            return door;
        }
    }
}
