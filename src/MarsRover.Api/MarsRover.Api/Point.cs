namespace MarsRover.Api
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            Y = y;
            X = x;
        }

        public override bool Equals(object? obj)
        {
            var point = obj as Point;
            if (point == null)
                return false;
            return point.X == X &&
                   point.Y == Y;
        }
    }
}
