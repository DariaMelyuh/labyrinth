using Library;
using Лаб1;

namespace Лаб2
{
    public class MazeBuilderWithBomb : MazeBuilder
    {
        public override Room BuildRoom(int Number)
        {
            RoomWithBomb room = new RoomWithBomb(Number);
            Maze.AddRoom(room);

            room.SetSide(Direction.North, new WallWithBomb());
            room.SetSide(Direction.South, new WallWithBomb());
            room.SetSide(Direction.West, new WallWithBomb());
            room.SetSide(Direction.East, new WallWithBomb());

            return room;
        }
        public override Door BuildDoor(int room1, int room2)
        {
            Room _room1 = Maze.RoomNo(room1);
            Room _room2 = Maze.RoomNo(room2);

            Door door = new Door(_room1, _room2);

            _room1.SetSide(Direction.East, door);
            _room2.SetSide(Direction.West, door);

            return door;
        }
    }
}
