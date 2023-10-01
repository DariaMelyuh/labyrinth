using Library;

namespace Лаб2
{
    public class MazeGame
    {
        public void CreateMaze(MazeBuilder builder)
        {
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);
        }
    }

}
