using System;
using System.Collections.Generic;
using System.Linq;

namespace HundredDoorsCodeKata
{
    public class DoorOperator
    {
        public DoorOperator(int numOfDoors)
        {
            if (numOfDoors <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(numOfDoors));
            }

            Doors = new List<Door>();
            for (var i = 0; i < numOfDoors; i++)
            {
                Doors.Add(new Door());
            }
        }

        public List<Door> Doors { get; }

        public string Operate(int numOfPasses)
        {
            for (var pass = 0; pass < numOfPasses; pass++)
            {
                for (var doorNum = 0; doorNum < Doors.Count; doorNum++)
                {
                    if ((doorNum + 1) % (pass + 1) == 0)
                    {
                        Doors[doorNum].IsOpen = !Doors[doorNum].IsOpen;
                    }
                }
            }

            return Doors.Aggregate(string.Empty, (current, door) => current + door.ToString());
        }
    }
}