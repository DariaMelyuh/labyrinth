using Library;
using Лаб1;
namespace Лаб3
{
    public class MazeWithBombGame : MazeGame
    {
        public override Room CreateRoom(int Number)
        {
            return new RoomWithBomb(Number);
        }

        public override Wall CreateWall()
        {
            return new WallWithBomb();
        }

        public override Door CreateDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }

        protected override Maze CreateMaze()
        {
            return new Maze();
        }
    }
}
