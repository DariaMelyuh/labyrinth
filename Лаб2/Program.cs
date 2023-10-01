using Library;
namespace Лаб2
{
    public class Program
    {
        static void Main(string[] args)
        {
            MazeBuilderWithBomb mazeBuilderWithBomb = new MazeBuilderWithBomb(); 
            MazeBuilderWithTrap mazeBuilderWithTrap = new MazeBuilderWithTrap();
            MazeGame mazeGame = new MazeGame();

            mazeGame.CreateMaze(mazeBuilderWithBomb);
            mazeGame.CreateMaze(mazeBuilderWithTrap); 

            Console.WriteLine("Лабиринт с ловушками:");
            Room roomWithTrap1 = mazeBuilderWithTrap.Maze.RoomNo(1);
            roomWithTrap1.Enter();

            Console.WriteLine("\nЛабиринт с бомбами:");
            Room roomWithBomb1 = mazeBuilderWithBomb.Maze.RoomNo(1);
            roomWithBomb1.Enter();

            Console.ReadLine();
        }
    }

}
