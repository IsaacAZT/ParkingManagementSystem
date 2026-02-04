using System;
using System.Collections.Generic; // Required to use Lists

namespace ParkingManagementSystem
{
    public class Parking
    {
        // Attributes
        // We create a list that only accepts 'Vehicle' type objects
        public List<Vehicle> CurrentVehicles { get; set; }
        public int Capacity { get; set; }

        // Constructor
        public Parking(int capacity)
        {
            Capacity = capacity;
            // It is vital to initialize the list so it is not empty (null)
            CurrentVehicles = new List<Vehicle>();
        }

        // Basic method to register entry (Stage 2)
        public void AddVehicle(Vehicle v)
        {
            if (CurrentVehicles.Count < Capacity)
            {
                CurrentVehicles.Add(v);
                Console.WriteLine($"Vehicle {v.LicensePlate} entered correctly.");
            }
            else
            {
                Console.WriteLine("Parking lot is full.");
            }
        }
    }
}