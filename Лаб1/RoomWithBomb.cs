using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;


namespace Лаб1
{
    public class RoomWithBomb : Room
    {
        private Random rnd = new Random();

        public RoomWithBomb(int roomNo) : base(roomNo) { }

        public override void Enter()
        {
            base.Enter();
            if (rnd.Next(2) == 0)
            {
                Console.WriteLine("Произошел взрыв");
                sides.OfType<WallWithBomb>().ToList().ForEach(x => x.Explode());
            }
        }
    }
}
