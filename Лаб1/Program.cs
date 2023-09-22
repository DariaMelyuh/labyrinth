using Library;
namespace Лаб1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MazeGame game = new MazeGame();
            Maze mazeWithBomb = game.Create(new MazeWithBombFactory());
            Maze mazeWithTrap = game.Create(new MazeWithTrapFactory());


            Console.WriteLine("Лабиринт!");
            Console.WriteLine();

            Room room1WithTrap = mazeWithTrap.RoomNo(1);
            room1WithTrap.Enter();


            Room room1WithBomb = mazeWithBomb.RoomNo(1);
            room1WithBomb.Enter();
          

            Console.ReadLine();
        }
    }
}
