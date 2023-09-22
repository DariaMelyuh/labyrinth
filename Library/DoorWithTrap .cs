using Library;
using System;
namespace Лаб1
{
    public class DoorWithTrap : Door
    {
        public DoorWithTrap(Room _room1, Room _room2) : base(_room1, _room2)
        { }

        public void Trap()
        {
            Console.WriteLine("Вас заперли!");
        }
    }
}