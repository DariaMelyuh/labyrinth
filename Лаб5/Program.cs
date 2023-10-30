using Library;
using Лаб1;
namespace MazeSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //var factory1 = MazeGame.Create(SingletonMazeFactory.Instance);
            //var factory2 = MazeGame.Create(SingletonMazeWithBombFactory.Instance);
            //var factory3 = MazeGame.Create(SingletonMazeWithTrapFactory.Instance);

           
            SingletonMazeFactory mazeFactory = SingletonMazeFactory.Instance;
            SingletonMazeWithBombFactory bombFactory = SingletonMazeWithBombFactory.Instance;
            SingletonMazeWithTrapFactory trapFactory = SingletonMazeWithTrapFactory.Instance;

           
            Maze standardMaze = mazeFactory.CreateMaze();
            Maze mazeWithBomb = bombFactory.CreateMaze();
            Maze mazeWithTrap = trapFactory.CreateMaze();
        }
    }
}