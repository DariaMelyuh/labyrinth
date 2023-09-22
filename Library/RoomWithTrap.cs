using Library;
using System;
namespace Лаб1
{
    public class RoomWithTrap : Room
    {
        private DoorWithTrap trapDoor;
        private readonly Room _room1;
        private readonly Room _room2;

        public RoomWithTrap(int roomNo) : base(roomNo)
        {
            _room1 = new Room(1);
            _room2 = new Room(2);

            trapDoor = new DoorWithTrap(_room1, _room2);
        }

        public override void Enter()
        {
            base.Enter();
            Console.WriteLine("Вы попали в ловушку!");
            trapDoor.Trap();
        }
    }
}
