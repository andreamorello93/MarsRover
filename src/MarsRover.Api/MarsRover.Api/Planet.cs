using System.Drawing;

namespace MarsRover.Api
{
    public class Planet
    {
        public int Width { get; }
        public int Height { get; }
        public Point[] Obstacles { get; }

        public Planet()
        {
            Width = 10;
            Height = 10;
            Obstacles = new Point[0];
        }
    
    }
}
