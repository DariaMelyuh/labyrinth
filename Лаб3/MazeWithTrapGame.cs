

using Library;
using Лаб1;
namespace Лаб3
{
    public class MazeWithTrapGame : MazeGame
    {
        public override Room CreateRoom(int Number)
        {
            return new RoomWithTrap(Number);
        }

        public override Wall CreateWall()
        {
            return new Wall();
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            return new DoorWithTrap(room1, room2);
        }

        protected override Maze CreateMaze()
        {
            return new Maze();
        }
    }
}
