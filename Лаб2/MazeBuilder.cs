using Library;
namespace Лаб2
{
    public class MazeBuilder
    {
        public Maze Maze;
        public MazeBuilder()
        {
            Maze = new();
        }

        public Maze GetMaze()
        {
            return Maze;
        }

        public virtual Room BuildRoom(int Number)
        {
            Room room = new Room(Number);
            Maze.AddRoom(room);
            return room;
        }

        public virtual Door BuildDoor(int room1, int room2)
        {
            return new Door(Maze.RoomNo(room1), Maze.RoomNo(room2));
        }

        public virtual Wall BuildWall()
        {
            return new Wall();
        }
       
    }
}
