using System.Collections.Generic;
using System.Linq;
namespace Library
{
    public class Maze
    {
        private List<Room> _rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Room? RoomNo(int roomNumber)
        {
            return _rooms.SingleOrDefault(room => room.Number == roomNumber);
        }
    }
}
