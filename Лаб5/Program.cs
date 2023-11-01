using Library;
using Лаб1;
namespace MazeSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonMazeFactory mazeFactory = SingletonMazeFactory.Instance;
            Maze standardMaze = mazeFactory.CreateMaze();
        }
    }
}