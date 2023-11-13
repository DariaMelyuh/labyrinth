using Лаб1;
namespace MazeSingleton
{
    public class MazeSingleton : MazeFactory
    {
        private static MazeSingleton? _instance;

        private MazeSingleton() { }

        public static MazeSingleton Instance
        {
            get
            {
                _instance ??= new MazeSingleton();
                return _instance;
            }
        }
    }
}