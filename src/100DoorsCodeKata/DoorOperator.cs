using System;

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

            NumberOfDoors = numOfDoors;
        }

        public int NumberOfDoors { get; }
    }
}