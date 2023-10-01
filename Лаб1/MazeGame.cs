using Library;
namespace Лаб1
{
    public class MazeGame
    {
        public Maze Create(MazeFactory factory)
        {
            Maze maze = factory.CreateMaze();
            Room room1 = factory.CreateRoom(1);
            Room room2 = factory.CreateRoom(2);
            Door theDoor = factory.CreateDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, factory.CreateWall());
            room1.SetSide(Direction.East, theDoor);
            room1.SetSide(Direction.South, factory.CreateWall());
            room1.SetSide(Direction.West, factory.CreateWall());

            room2.SetSide(Direction.North, factory.CreateWall());
            room2.SetSide(Direction.East, factory.CreateWall());
            room2.SetSide(Direction.South, factory.CreateWall());
            room2.SetSide(Direction.West, theDoor);

            return maze;
        }
    }
}
