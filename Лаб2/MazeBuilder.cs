using Library;
namespace Лаб2
{
    public abstract class MazeBuilder
    {
        protected Maze _maze;
        public abstract void BuildMaze();
        public abstract void BuildRoom(int Number);
        public abstract void BuildDoor(int room1, int room2);
        public virtual Maze GetMaze()
        {
            return _maze;
        }
    }
}
