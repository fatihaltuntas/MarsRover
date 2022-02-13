using System;

namespace MarsRover
{
    public class Plateau
    {
        public int MaxX;
        public int MaxY;

        public Plateau(string location)
        {
            MaxX = Convert.ToInt32(location.Split(" ")[0]);
            MaxY = Convert.ToInt32(location.Split(" ")[1]);
        }
    }
}
