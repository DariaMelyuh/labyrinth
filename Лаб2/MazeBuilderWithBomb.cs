using Library;
using Лаб1;

namespace Лаб2
{
    public class MazeBuilderWithBomb : MazeBuilder
    {
        public override void BuildRoom(int number)
        {
            RoomWithBomb room = new RoomWithBomb(number);
            ArgumentNullException.ThrowIfNull(room);
            Maze.AddRoom(room);

            room.SetSide(Direction.North, new WallWithBomb());
            room.SetSide(Direction.South, new WallWithBomb());
            room.SetSide(Direction.West, new WallWithBomb());
            room.SetSide(Direction.East, new WallWithBomb());
        }
        protected override Door CreaateDoor(Room room1, Room room2)
        {
            ArgumentNullException.ThrowIfNull(room1);
            ArgumentNullException.ThrowIfNull(room2);
            return new DoorWithTrap(room1, room2);
        }
        
    }
}
