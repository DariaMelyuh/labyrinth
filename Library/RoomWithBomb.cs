using System;
using System.Linq;
using Library;
namespace Лаб1
{
    public class RoomWithBomb : Room
    {
        private static Random Rnd = new Random();
        
        public RoomWithBomb(int Number) : base(Number) { }

        public override void Enter()
        {
            base.Enter();
            if (Rnd.Next(2) == 0)
            {
                Console.WriteLine("Произошел взрыв");
                Sides.OfType<WallWithBomb>().ToList().ForEach(x => x.Explode());
            }
        }
    }
}
