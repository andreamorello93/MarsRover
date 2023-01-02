namespace MarsRover.Api
{
    public class Planet
    {
        public int Width { get; }
        public int Height { get; }
        public Point[] Obstacles { get; }

        public Planet(Point[] obstacles)
        {
            Width = 10;
            Height = 10;
            Obstacles = obstacles;
        }

        public Planet()
        {
            Width = 10;
            Height = 10;
            Obstacles = new Point[] { new(1, 2), new(4, 5), new(5, 5) };
        }
    }
}
