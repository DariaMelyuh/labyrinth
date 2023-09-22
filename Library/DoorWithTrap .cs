using Library;
using System;
namespace Лаб1
{
    public class DoorWithTrap : Door
    {
        public DoorWithTrap(Room room1, Room room2) : base(room1, room2)
        { }

        public void Trap()
        {
            Console.WriteLine("Вас заперли!");
        }
    }
}