﻿using Library;
using Лаб1;

namespace Лаб2
{
    public class MazeWithBombBuilder : MazeBuilder
    {
        public override void BuildMaze()
        {
            _maze = new Maze();
        }

        public override void BuildRoom(int Number)
        {
            RoomWithBomb room = new RoomWithBomb(Number);
            _maze.AddRoom(room);

            room.SetSide(Direction.North, new WallWithBomb());
            room.SetSide(Direction.South, new WallWithBomb());
           // room.SetSide(Direction.West, new WallWithBomb());
           // room.SetSide(Direction.East, new WallWithBomb());
        }

        public override void BuildDoor(int room1, int room2)
        {
            Room _room1 = _maze.RoomNo(room1);
            Room _room2 = _maze.RoomNo(room2);

            Door door = new Door(_room1, _room2);

            _room1.SetSide(Direction.East, door);
            _room2.SetSide(Direction.West, door);
        }
    }
}
