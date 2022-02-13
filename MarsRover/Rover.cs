using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Direction { get; set; }
        public Rover(string location)
        {
            X = Convert.ToInt32(location.Split(" ")[0]);
            Y = Convert.ToInt32(location.Split(" ")[1]);
            Direction = location.Split(" ")[2];
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case "N":
                    Direction = "W";
                    break;
                case "W":
                    Direction = "S";
                    break;
                case "S":
                    Direction = "E";
                    break;
                case "E":
                    Direction = "N";
                    break;
                default:
                    throw new Exception();
            }
        }

        public void TurnRight()
        {
            switch (Direction)
            {
                case "N":
                    Direction = "E";
                    break;
                case "E":
                    Direction = "S";
                    break;
                case "S":
                    Direction = "W";
                    break;
                case "W":
                    Direction = "N";
                    break;
                default:
                    throw new Exception();
            }
        }

        public void Go()
        {
            switch (Direction)
            {
                case "N":
                    Y++;
                    break;
                case "W":
                    X--;
                    break;
                case "S":
                    Y--;
                    break;
                case "E":
                    X++;
                    break;
                default:
                    throw new Exception();
            }
        }

        public string Move(string commands)
        {
            List<string> commandList = new List<string>();
            commandList.AddRange(commands.Select(c => c.ToString()));
            foreach (var command in commandList)
            {
                switch (command)
                {
                    case "M":
                        Go();
                        break;
                    case "L":
                        TurnLeft();
                        break;
                    case "R":
                        TurnRight();
                        break;
                    default:
                        throw new Exception();
                }
            }
            return this.X + " " + this.Y + " " + this.Direction;
        }
    }
}
