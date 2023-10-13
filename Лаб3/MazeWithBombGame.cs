using Library;
using Лаб1;
namespace Лаб3
{
    public class MazeWithBombGame : MazeGame
    {
        protected override Room CreateRoom(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), number, "Number не может быть отрицательным.");
            }
            return new RoomWithBomb(number);
        }

        protected override Wall CreateWall()
        {
            return new WallWithBomb();
        }
    }
}
