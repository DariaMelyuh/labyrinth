using Library;
using Лаб1;
namespace Лаб3
{
    public class MazeWithBombGame : MazeGame
    {
        public override Room CreateRoom(int Number)
        {
            return new RoomWithBomb(Number);
        }

        public override Wall CreateWall()
        {
            return new WallWithBomb();
        }
    }
}
