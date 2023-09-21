using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Room : IMapSite
    {
        protected readonly IMapSite[] sides;
        private readonly int roomNumber;

        public int RoomNumber
        {
            get { return roomNumber; }
        }

        public Room(int roomNo)
        {
            roomNumber = roomNo;
            sides = new IMapSite[4];
        }

        public IMapSite GetSide(Direction direction)
        {
            return sides[(int)direction];
        }

        public void SetSide(Direction direction, IMapSite site)
        {
            sides[(int)direction] = site;
        }

        public virtual void Enter()
        {
            Console.WriteLine($"Вы находитесь в комнате {RoomNumber}.");
        }
    }
}
