using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Лаб1
{
    public class MazeWithBombFactory : MazeFactory
    {
        public override Wall CreateWall()
        {
            return new WallWithBomb();
        }

        public override Room CreateRoom(int roomNumber)
        {
            return new RoomWithBomb(roomNumber);
        }
    }
}
