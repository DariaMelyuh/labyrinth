using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Лаб1
{
    public class MazeGame
    {
        public Maze Create(MazeFactory factory)
        {
            Maze maze = factory.CreateMaze();
            Room r1 = factory.CreateRoom(1);
            Room r2 = factory.CreateRoom(2);
            Door theDoor = factory.CreateDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);

            r1.SetSide(Direction.North, factory.CreateWall());
            r1.SetSide(Direction.East, theDoor);
            r1.SetSide(Direction.South, factory.CreateWall());
            r1.SetSide(Direction.West, factory.CreateWall());

            r2.SetSide(Direction.North, factory.CreateWall());
            r2.SetSide(Direction.East, factory.CreateWall());
            r2.SetSide(Direction.South, factory.CreateWall());
            r2.SetSide(Direction.West, theDoor);

            return maze;
        }
    }
}
