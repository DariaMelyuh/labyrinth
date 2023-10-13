using Library;
namespace Лаб3
{
    public abstract class MazeGame
    {
        public Maze Create()
        {
            Maze maze = CreateMaze();
            Room room1 = CreateRoom(1);
            ArgumentNullException.ThrowIfNull(room1);
            Room room2 = CreateRoom(2);
            ArgumentNullException.ThrowIfNull(room2);
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

        protected virtual Room CreateRoom(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Number не может быть отрицательным.");
            }
            Room room = new Room(number);
            ArgumentNullException.ThrowIfNull(room);
            return room;
        }

        protected virtual Door CreateDoor(Room room1, Room room2)
        {
            ArgumentNullException.ThrowIfNull(room1);
            ArgumentNullException.ThrowIfNull(room2);
            return new Door(room1, room2);
        }

        protected virtual Wall CreateWall()
        {
            return new Wall();
        }

        protected virtual Maze CreateMaze()
        {
            return new Maze();
        }
    }
}
