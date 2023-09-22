using Library;
namespace Лаб1
{
    public abstract class MazeFactory
    {
        public virtual Maze CreateMaze() => new Maze();
        public virtual Room CreateRoom(int Number) => new Room(Number);
        public virtual Wall CreateWall() => new Wall();
        public virtual Door CreateDoor(Room _room1, Room _room2) => new Door(_room1, _room2);
    }
}
