using System;
namespace Library
{
    public class Room : IMapSite
    {
        public int Number { get; private init; }
        protected  IMapSite[] Sides { get; private init; }
        

        public Room(int Number)
        {
            this.Number = Number;
            Sides = new IMapSite[4];
        }

        public IMapSite GetSide(Direction direction)
        {
            return Sides[(int)direction];
        }

        public void SetSide(Direction direction, IMapSite site)
        {
            Sides[(int)direction] = site;
        }

        public virtual void Enter()
        {
            Console.WriteLine($"Вы находитесь в комнате {Number}.");
        }
    }
}
