using Library;
namespace Лаб3
{
    public abstract class MazeGame
    {
        public Maze Create()
        {
            Maze maze = CreateMaze();
            Room room1 = CreateRoom(1);
            Room room2 = CreateRoom(2);
            Door door = CreateDoor(room1, room2);

            maze.AddRoom(room1);
            maze.AddRoom(room2);

            room1.SetSide(Direction.North, CreateWall());
            room1.SetSide(Direction.East, door);
            room1.SetSide(Direction.South, CreateWall());
            room1.SetSide(Direction.West, CreateWall());

            room2.SetSide(Direction.North, CreateWall());
            room2.SetSide(Direction.East, CreateWall());
            room2.SetSide(Direction.South, CreateWall());
            room2.SetSide(Direction.West, door);

            return maze;
        }

        public virtual Room CreateRoom(int Number)
        {
            Room room = new Room(Number);
            return room;
        }


        public virtual Door CreateDoor(Room room1, Room room2)
        {
            return new Door(room1, room2);
        }
        public virtual Wall CreateWall()
        {
            return new Wall();
        }
        public virtual Maze CreateMaze()
        {
            return new Maze();
        }
    }
}
