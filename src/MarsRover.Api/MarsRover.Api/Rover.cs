
namespace MarsRover.Api
{
    public enum Direction { N, S, E, W }
    public enum Commands { F, B, L, R }

    public class Rover
    {
        private readonly Planet _planet = new Planet();

        public Point Position { get; set; }
        public Direction? Direction { get; set; }

        public Rover()
        {

        }

        public Rover(int x, int y, Direction direction)
        {
            Initalize(x, y, direction);
        }

        public Rover Initalize(int x, int y, Direction direction)
        {
            if(x > _planet.Width)
                x = 0;

            if (y > _planet.Height)
                y = 0;

            Position = new Point(x, y);            
            Direction = direction;

            return this;
        }
    }

}
