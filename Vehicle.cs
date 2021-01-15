using System;

namespace ClassHierarchy
{
    public class Vehicle
    {
        public int MaxOccupants{get;set;}

        private static int numberOfVehiclesCreated = 0;
        public static int NumberOfVehiclesCreated
        {
            get
            {
                return numberOfVehiclesCreated;
            }
        }

        public Vehicle()
        {
            numberOfVehiclesCreated++;
        }
    }
}