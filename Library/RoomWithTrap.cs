using Library;
using System;
namespace Лаб1
{
    public class RoomWithTrap : Room
    {
        private readonly DoorWithTrap _trapDoor;
        private readonly Room _room1;
        private readonly Room _room2;

        public RoomWithTrap(int Number) : base(Number)
        {
            _room1 = new Room(1);
            _room2 = new Room(2);

            _trapDoor = new DoorWithTrap(_room1, _room2);
        }

        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Вы попали в ловушку!");
            _trapDoor.Enter();
        }
    }
}
