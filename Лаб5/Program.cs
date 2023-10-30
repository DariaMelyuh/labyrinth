using Library;
using Лаб1;
namespace MazeSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonMazeFactory mazeFactory = SingletonMazeFactory.Instance;
            SingletonMazeWithBombFactory bombFactory = SingletonMazeWithBombFactory.Instance;
            SingletonMazeWithTrapFactory trapFactory = SingletonMazeWithTrapFactory.Instance;

            Maze standardMaze = mazeFactory.CreateMaze();
            Maze mazeWithBomb = bombFactory.CreateMaze();
            Maze mazeWithTrap = trapFactory.CreateMaze();
        }
    }
}