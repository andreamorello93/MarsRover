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
                            PlusY();
                        if (Direction == Api.Direction.E)
                            PlusX();
                        if (Direction == Api.Direction.S)
                            MinusY();
                        if (Direction == Api.Direction.W)
                            MinusX();
                        break;
                    case Commands.B:
                        if (Direction == Api.Direction.N)
                            MinusY();
                        if (Direction == Api.Direction.E)
                            MinusX();
                        if (Direction == Api.Direction.S)
                            PlusX();
                        if (Direction == Api.Direction.W)
                            PlusX();
                        break;
                    case Commands.L:
                        if (Direction == Api.Direction.N)
                            Direction = Api.Direction.W;
                        else if (Direction == Api.Direction.E)
                            Direction = Api.Direction.N;
                        else if(Direction == Api.Direction.S)
                            Direction = Api.Direction.E;
                        else if(Direction == Api.Direction.W)
                            Direction = Api.Direction.S;
                        break;
                    case Commands.R:
                        if (Direction == Api.Direction.N)
                            Direction = Api.Direction.E;
                        else if(Direction == Api.Direction.E)
                            Direction = Api.Direction.S;
                        else if(Direction == Api.Direction.S)
                            Direction = Api.Direction.W;
                        else if(Direction == Api.Direction.W)
                            Direction = Api.Direction.N;
                        break;
                }

            return string.Empty;
        }

        private void MinusX()
        {
            Position.X--;

            if (Position.X < 0)
                Position.X = _planet.Width;
        }

        private void MinusY()
        {
            Position.Y--;

            if (Position.Y < 0)
                Position.Y = _planet.Height;
        }

        private void PlusY()
        {
            Position.Y++;

            if (Position.Y > _planet.Height)
                Position.Y = 0;
        }

        private void PlusX()
        {
            Position.X++;

            if (Position.X > _planet.Width)
                Position.X = 0;
        }
    }

}
