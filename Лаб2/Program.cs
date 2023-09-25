using Library;
namespace Лаб2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MazeBuilder mazeBuilderWithBomb = new MazeBuilderWithBomb();
            MazeBuilder mazeBuilderWithTrap = new MazeBuilderWithTrap();
            MazeGame mazeGame = new MazeGame();
           
            Maze mazeWithBomb = mazeGame.CreateMaze(mazeBuilderWithBomb);
            Maze mazeWithTrap = mazeGame.CreateMaze(mazeBuilderWithTrap);
            
            Console.WriteLine("Лабиринт!");
            Room roomWithTrap1 = mazeWithTrap.RoomNo(1);
            roomWithTrap1.Enter();
            Room roomWithBomb1 = mazeWithBomb.RoomNo(1);
            roomWithBomb1.Enter();
            Console.ReadLine();
        }
    }
}
