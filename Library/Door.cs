using System;
namespace Library
{
    public class Door : IMapSite
    {
        private readonly Room _room1;
        private readonly Room _room2;
        private readonly bool _isOpen;

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
            _isOpen = true;
        }

        public void Enter()
        {
            if (_isOpen)
            {
                Console.WriteLine("Дверь открыта, Вы проходите через дверь");
            }
            else
            {
                Console.WriteLine("Дверь закрыта, Вы не можете пройти.");
            }
        }
        public Room OtherSideFrom(Room room)
        {
            if (room.Number == _room1.Number)
            {
                return _room2;
            }
            else if (room.Number == _room2.Number)
            {
                return _room1;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
    }
}
