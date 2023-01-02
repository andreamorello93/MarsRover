﻿using NUnit.Framework;
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

        [Test]
        public void Process_Commands_F_F_B()
        {
            var actual = new Rover(0, 0, Direction.E);

            var commands = new[] {Commands.F, Commands.F, Commands.B};

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 0 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_B_F_B()
        {
            var actual = new Rover(3, 5, Direction.N);

            var commands = new[] { Commands.B, Commands.F, Commands.B };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 3, Y = 4 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_F_F_F()
        {
            var actual = new Rover(3, 5, Direction.S);

            var commands = new[] { Commands.F, Commands.F, Commands.F };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 3, Y = 2 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_B_F_F()
        {
            var actual = new Rover(7, 3, Direction.E);

            var commands = new[] { Commands.B, Commands.F, Commands.F };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 8, Y = 3 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_F_B_B()
        {
            var actual = new Rover(7, 3, Direction.W);

            var commands = new[] { Commands.F, Commands.B, Commands.B };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 8, Y = 3 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_L()
        {
            var actual = new Rover(6, 2, Direction.N);

            var commands = new[] { Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 6, Y = 2 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_R()
        {
            var actual = new Rover(1, 2, Direction.N);

            var commands = new[] { Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 2 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_L()
        {
            var actual = new Rover(4, 2, Direction.E);

            var commands = new[] { Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 4, Y = 2 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_R()
        {
            var actual = new Rover(6, 8, Direction.W);

            var commands = new[] { Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 6, Y = 8 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_L()
        {
            var actual = new Rover(3, 3, Direction.S);

            var commands = new[] { Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 3, Y = 3 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_R()
        {
            var actual = new Rover(2, 2, Direction.S);

            var commands = new[] { Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 2, Y = 2 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_L()
        {
            var actual = new Rover(1, 3, Direction.W);

            var commands = new[] { Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_R()
        {
            var actual = new Rover(2, 1, Direction.W);

            var commands = new[] { Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 2, Y = 1 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_L_L_L_L()
        {
            var actual = new Rover(1, 3, Direction.N);

            var commands = new[] { Commands.L, Commands.L, Commands.L, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_L_L_L_L()
        {
            var actual = new Rover(1, 3, Direction.E);

            var commands = new[] { Commands.L, Commands.L, Commands.L, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_L_L_L_L()
        {
            var actual = new Rover(1, 3, Direction.S);

            var commands = new[] { Commands.L, Commands.L, Commands.L, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_L_L_L_L()
        {
            var actual = new Rover(1, 3, Direction.W);

            var commands = new[] { Commands.L, Commands.L, Commands.L, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_R_R_R_R()
        {
            var actual = new Rover(1, 3, Direction.N);

            var commands = new[] { Commands.R, Commands.R, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.N };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_R_R_R_R()
        {
            var actual = new Rover(1, 3, Direction.E);

            var commands = new[] { Commands.R, Commands.R, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_R_R_R_R()
        {
            var actual = new Rover(1, 3, Direction.S);

            var commands = new[] { Commands.R, Commands.R, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_R_R_R_R()
        {
            var actual = new Rover(1, 3, Direction.W);

            var commands = new[] { Commands.R, Commands.R, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_N_R_L_R_R()
        {
            var actual = new Rover(1, 3, Direction.W);

            var commands = new[] { Commands.R, Commands.L, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.E };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_E_L_L_R_R()
        {
            var actual = new Rover(1, 3, Direction.W);

            var commands = new[] { Commands.L, Commands.L, Commands.R, Commands.R };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_S_L_R_R_L()
        {
            var actual = new Rover(1, 3, Direction.S);

            var commands = new[] { Commands.L, Commands.R, Commands.R, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.S };

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void Process_Commands_W_R_R_L_L()
        {
            var actual = new Rover(1, 3, Direction.W);

            var commands = new[] { Commands.R, Commands.R, Commands.L, Commands.L };

            actual.ProcessCommands(commands);

            var expected = new { Position = new { X = 1, Y = 3 }, Direction = Direction.W };

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
