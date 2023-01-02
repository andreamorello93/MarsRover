using System.Linq;

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

        public string ProcessCommands(Commands[] commands)
        {
            foreach (var command in commands)
                switch (command)
                {
                    case Commands.F:
                        if (Direction == Api.Direction.N)
                            Position.Y++;
                        if (Direction == Api.Direction.E)
                            Position.X++;
                        if (Direction == Api.Direction.S)
                            Position.Y--;
                        if (Direction == Api.Direction.W)
                            Position.X--;
                        break;
                    case Commands.B:
                        if (Direction == Api.Direction.N)
                            Position.Y--;
                        if (Direction == Api.Direction.E)
                            Position.X--;
                        if (Direction == Api.Direction.S)
                            Position.X++;
                        if (Direction == Api.Direction.W)
                            Position.X++;
                        break;
                }

            return string.Empty;
        }
    }

}
