using MarsRover;
using System;
using Xunit;

namespace MarsRoverTests
{
    public class RoverShould
    {
        [Fact]
        public void TurnLeft()
        {
            Rover rover = new Rover("1 2 S");
            rover.TurnLeft();
            Assert.Equal("E", rover.Direction);
        }
        [Fact]
        public void TurnRight()
        {
            Rover rover = new Rover("1 2 S");
            rover.TurnRight();
            Assert.Equal("W", rover.Direction);
        }
        [Fact]
        public void Go()
        {
            Rover rover = new Rover("1 2 N");
            rover.Go();
            Assert.Equal(3, rover.Y);
        }
        [Fact]
        public void Move()
        {
            Rover rover = new Rover("1 2 N");
            rover.Move("LMLMLMLMM");
            Assert.Equal("1 3 N", rover.X + " " + rover.Y + " " + rover.Direction);
        }
    }
}
