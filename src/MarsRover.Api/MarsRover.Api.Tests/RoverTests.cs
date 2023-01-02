using FluentAssertions;
using NUnit.Framework;

namespace MarsRover.Api.Tests
{
    [TestFixture]
    public class RoverTests
    {
        [Test]
        public void Initialize_Rover_2_5_N()
        {
            var actual = new Rover(2, 5, Direction.N, new Planet(Array.Empty<Point>()));

            var expected = new { Position = new { X = 2, Y = 5 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Initialize_Rover_7_1_W()
        {
            var actual = new Rover(7, 1, Direction.W, new Planet(Array.Empty<Point>()));

            var expected = new { Position = new { X = 7, Y = 1 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Initialize_Rover_12_1_W()
        {
            var actual = new Rover(12, 1, Direction.W, new Planet(Array.Empty<Point>()));

            var expected = new { Position = new { X = 0, Y = 1 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Initialize_Rover_4_15_E()
        {
            var actual = new Rover(4, 15, Direction.E, new Planet(Array.Empty<Point>()));

            var expected = new { Position = new { X = 4, Y = 0 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_F_F_B()
        {
            var actual = new Rover(0, 0, Direction.E, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.F, Commands.F, Commands.B };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 0 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_B_F_B()
        {
            var actual = new Rover(3, 5, Direction.N, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.B, Commands.F, Commands.B };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 3, Y = 4 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_F_F_F()
        {
            var actual = new Rover(3, 5, Direction.S, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.F, Commands.F, Commands.F };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 3, Y = 2 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_B_F_F()
        {
            var actual = new Rover(7, 3, Direction.E, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.B, Commands.F, Commands.F };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 8, Y = 3 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_F_B_B()
        {
            var actual = new Rover(7, 3, Direction.W, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.F, Commands.B, Commands.B };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 8, Y = 3 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_L()
        {
            var actual = new Rover(6, 2, Direction.N, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 6, Y = 2 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_R()
        {
            var actual = new Rover(1, 2, Direction.N, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 2 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_L()
        {
            var actual = new Rover(4, 2, Direction.E, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 4, Y = 2 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_R()
        {
            var actual = new Rover(6, 8, Direction.W, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 6, Y = 8 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_L()
        {
            var actual = new Rover(3, 3, Direction.S, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 3, Y = 3 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_R()
        {
            var actual = new Rover(2, 2, Direction.S, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 2, Y = 2 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_L()
        {
            var actual = new Rover(1, 3, Direction.W, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_R()
        {
            var actual = new Rover(2, 1, Direction.W, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 2, Y = 1 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_L_L_L_L()
        {
            var actual = new Rover(1, 3, Direction.N, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.L, Commands.L, Commands.L, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_L_L_L_L()
        {
            var actual = new Rover(1, 3, Direction.E, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.L, Commands.L, Commands.L, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_L_L_L_L()
        {
            var actual = new Rover(1, 3, Direction.S, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.L, Commands.L, Commands.L, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_L_L_L_L()
        {
            var actual = new Rover(1, 3, Direction.W, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.L, Commands.L, Commands.L, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_R_R_R_R()
        {
            var actual = new Rover(1, 3, Direction.N, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.R, Commands.R, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_R_R_R_R()
        {
            var actual = new Rover(1, 3, Direction.E, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.R, Commands.R, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_R_R_R_R()
        {
            var actual = new Rover(1, 3, Direction.S, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.R, Commands.R, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_R_R_R_R()
        {
            var actual = new Rover(1, 3, Direction.W, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.R, Commands.R, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_R_L_R_R()
        {
            var actual = new Rover(1, 3, Direction.W, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.R, Commands.L, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_L_L_R_R()
        {
            var actual = new Rover(1, 3, Direction.W, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.L, Commands.L, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_L_R_R_L()
        {
            var actual = new Rover(1, 3, Direction.S, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.L, Commands.R, Commands.R, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_R_R_L_L()
        {
            var actual = new Rover(1, 3, Direction.W, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.R, Commands.R, Commands.L, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_WrapEdge_E_B_B_B()
        {
            var actual = new Rover(1, 3, Direction.E, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.B, Commands.B, Commands.B };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 9, Y = 3 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_WrapEdge_N_B_B_B()
        {
            var actual = new Rover(1, 2, Direction.N, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.B, Commands.B, Commands.B };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 10 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_WrapEdge_S_F_F_F()
        {
            var actual = new Rover(1, 2, Direction.S, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.F, Commands.F, Commands.F };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 10 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_WrapEdge_W_F_F_F()
        {
            var actual = new Rover(1, 2, Direction.W, new Planet(Array.Empty<Point>()));

            var commands = new[] { Commands.F, Commands.F, Commands.F };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 9, Y = 2 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_3_Obstacle_NoDetection()
        {
            var actual = new Rover(1, 1, Direction.N, new Planet(new Point[] { new(1, 4), new(6, 7), new(4, 4) }));

            var commands = new[] { Commands.F, Commands.F, Commands.L, Commands.F, Commands.F, Commands.R, Commands.F, Commands.F };

            var actualCommandResult = actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 10, Y = 5 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);

            actualCommandResult.Should().Be(Constants.COMMAND_RESULT_OK);
        }

        [Test]
        public void Process_Commands_1_Obstacle_Detection()
        {
            var actual = new Rover(1, 2, Direction.N, new Planet(new Point[]{new (1,4)}));

            var commands = new[] { Commands.F, Commands.F, Commands.F };

            var actualCommandResult = actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);

            actualCommandResult.Should().Be(string.Format(Constants.COMMAND_RESULT_KO, 1, 4));
        }

        [Test]
        public void Process_Commands_5_Obstacle_NoDetection()
        {
            var actual = new Rover(1, 1, Direction.N, 
                new Planet(new Point[]
                {
                    new(1, 4), 
                    new(6, 7), 
                    new(8, 4),
                    new(3, 3),
                    new(2, 5),
                }));

            var commands = new[]
            {
                Commands.F, 
                Commands.F, 
                Commands.L, 
                Commands.F, 
                Commands.F, 
                Commands.R, 
                Commands.F, 
                Commands.F,
                Commands.R,
                Commands.B,
                Commands.B,
            };

            var actualCommandResult = actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 8, Y = 5 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);

            actualCommandResult.Should().Be(Constants.COMMAND_RESULT_OK);
        }

        [Test]
        public void Process_Commands_2_Obstacle_Detection()
        {
            var actual = new Rover(2, 2, Direction.N, new Planet(new Point[] { new(3, 4), new(5, 2) }));

            var commands = new[] { Commands.R, Commands.F, Commands.F, Commands.F, };

            var actualCommandResult = actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 4, Y = 2 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);

            actualCommandResult.Should().Be(string.Format(Constants.COMMAND_RESULT_KO, 5, 2));
        }
    }
}
