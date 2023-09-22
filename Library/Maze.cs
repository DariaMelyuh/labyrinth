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

        public Room? RoomNo(int Number)
        {
            return _rooms.SingleOrDefault(room => room.Number == Number);
        }
    }
}
