using System;
using System.Collections.Generic;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> roversCordinatesAndHeadingList = new List<string>();
            Console.WriteLine("Write plateau:");
            Plateau plateau = new Plateau(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Write rover position:");
                Rover rover = new Rover(Console.ReadLine());
                Console.WriteLine("Rover commands:");
                string roverFinallyCordinatesAndHeading = rover.Move(Console.ReadLine());
                roversCordinatesAndHeadingList.Add(roverFinallyCordinatesAndHeading);
                Console.WriteLine("Add another rover ? Y/N");
                var isAddAnotherRover = Console.ReadLine();

                if (!isAddAnotherRover.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                {
                    foreach (var roverPositionAndHeading in roversCordinatesAndHeadingList)
                    {
                        Console.WriteLine(roverPositionAndHeading);
                    }
                    break;
                }
            }
        }
    }
}
