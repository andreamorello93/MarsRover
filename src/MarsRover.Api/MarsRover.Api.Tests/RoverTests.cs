using NUnit.Framework;
using FluentAssertions;
using System.Drawing;

namespace MarsRover.Api.Tests
{    
    [TestFixture]
    public class RoverTests
    {
        [Test]
        public void Initialize_Rover_2_5_N()
        {
            var actual = new Rover(2, 5, Direction.N);

            var expected = new { Position = new { X = 2, Y = 5 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Initialize_Rover_7_1_W()
        {
            var actual = new Rover(7, 1, Direction.W);

            var expected = new { Position = new { X = 7, Y = 1 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Initialize_Rover_12_1_W()
        {
            var actual = new Rover(12, 1, Direction.W);

            var expected = new { Position = new { X = 0, Y = 1 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Initialize_Rover_4_15_E()
        {
            var actual = new Rover(4, 15, Direction.E);

            var expected = new { Position = new { X = 4, Y = 0 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
