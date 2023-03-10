namespace MarsRover.Api
{
    public enum Direction { N, S, E, W }
    public enum Commands { F, B, L, R }

    public class Rover
    {
        public Planet Planet { get; private set; }
        public Point Position { get; set; }
        public Direction? Direction { get; set; }

        public Rover()
        {
            Planet = new Planet(Array.Empty<Point>());
            Position = new Point(0, 0);
            Direction = Api.Direction.N;
        }

        public Rover(int x, int y, Direction direction, Planet planet)
        {
            Initalize(x, y, direction, planet);
        }

        public Rover Initalize(int x, int y, Direction direction, Planet planet)
        {
            Planet = planet;

            if (x > Planet.Width) x = 0;

            if (y > Planet.Height) y = 0;

            Position = new Point(x, y);

            if (CheckObstacle(Position))
                throw new ApplicationException(FormatObstacleMessage(Position));

            Direction = direction;

            return this;
        }

        public string ProcessCommands(Commands[] commands)
        {
            var commandResult = string.Empty;

            foreach (var command in commands)
            {
                commandResult = ProcessCommand(command);

                if (!commandResult.Equals(Constants.COMMAND_RESULT_OK))
                    break;
            }

            return commandResult;
        }

        private string ProcessCommand(Commands command)
        {
            switch (command)
            {
                case Commands.F:
                    if (Direction == Api.Direction.N)
                        return PlusY();
                    if (Direction == Api.Direction.E)
                        return PlusX();
                    if (Direction == Api.Direction.S)
                        return MinusY();
                    if (Direction == Api.Direction.W)
                        return MinusX();
                    break;
                case Commands.B:
                    if (Direction == Api.Direction.N)
                        return MinusY();
                    if (Direction == Api.Direction.E)
                        return MinusX();
                    if (Direction == Api.Direction.S)
                        return PlusX();
                    if (Direction == Api.Direction.W)
                        return PlusX();
                    break;
                case Commands.L:
                    if (Direction == Api.Direction.N)
                        Direction = Api.Direction.W;
                    else if (Direction == Api.Direction.E)
                        Direction = Api.Direction.N;
                    else if (Direction == Api.Direction.S)
                        Direction = Api.Direction.E;
                    else if (Direction == Api.Direction.W)
                        Direction = Api.Direction.S;
                    break;
                case Commands.R:
                    if (Direction == Api.Direction.N)
                        Direction = Api.Direction.E;
                    else if (Direction == Api.Direction.E)
                        Direction = Api.Direction.S;
                    else if (Direction == Api.Direction.S)
                        Direction = Api.Direction.W;
                    else if (Direction == Api.Direction.W)
                        Direction = Api.Direction.N;
                    break;
            }

            return Constants.COMMAND_RESULT_OK;
        }

        private string MinusX()
        {
            var projectionPoint = new Point(Position.X + 1, Position.Y);

            if (CheckObstacle(projectionPoint))
                return FormatObstacleMessage(projectionPoint);

            Position.X--;

            if (Position.X < 0)
                Position.X = Planet.Width;

            return CommandResultOk();
        }

        private static string FormatObstacleMessage(Point projectionPoint)
        {
            return string.Format(Constants.COMMAND_RESULT_KO, projectionPoint.X, projectionPoint.Y);
        }

        private string MinusY()
        {
            var projectionPoint = new Point(Position.X, Position.Y - 1);

            if (CheckObstacle(projectionPoint))
                return FormatObstacleMessage(projectionPoint);

            Position.Y--;

            if (Position.Y < 0)
                Position.Y = Planet.Height;

            return CommandResultOk();
        }

        private string PlusY()
        {
            var projectionPoint = new Point(Position.X, Position.Y + 1);

            if (CheckObstacle(projectionPoint))
                return FormatObstacleMessage(projectionPoint);

            Position.Y++;

            if (Position.Y > Planet.Height)
                Position.Y = 0;

            return CommandResultOk();
        }

        private string PlusX()
        {
            var projectionPoint = new Point(Position.X + 1, Position.Y);
            if (CheckObstacle(projectionPoint))
                return FormatObstacleMessage(projectionPoint);

            Position.X++;

            if (Position.X > Planet.Width)
                Position.X = 0;

            return CommandResultOk();
        }

        private static string CommandResultOk()
        {
            return Constants.COMMAND_RESULT_OK;
        }

        private bool CheckObstacle(Point projectionPoint)
        {
            return Planet.Obstacles.Any(o => o.Equals(projectionPoint));
        }
    }

}
