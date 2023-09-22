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
