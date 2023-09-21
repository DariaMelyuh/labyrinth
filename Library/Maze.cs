using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Maze
    {
        private List<Room> rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public Room? RoomNo(int roomNumber)
        {
            return rooms.FirstOrDefault(room => room.RoomNumber == roomNumber);
        }
    }
}
