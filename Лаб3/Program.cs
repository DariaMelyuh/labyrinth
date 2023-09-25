using Library;
namespace Лаб3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            MazeGame gameWithTrap = new MazeWithTrapGame();
            Maze mazeWithTrap = gameWithTrap.Create();

            Room startingRoom2 = mazeWithTrap.RoomNo(1);
            startingRoom2.Enter();
          
           
            MazeGame gameWithBomb = new MazeWithBombGame();
            Maze mazeWithBomb = gameWithBomb.Create();

           
            Room startingRoom = mazeWithBomb.RoomNo(1);
            startingRoom.Enter();
      
       
            Console.ReadLine();
        }
    }
}