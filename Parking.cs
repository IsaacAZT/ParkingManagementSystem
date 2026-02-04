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


        public decimal HourlyRate { get; set; } = 2.00m;

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
        public void RemoveVehicle(string plate)
        {
            // 1. Search for the vehicle by license plate
            var vehicle = CurrentVehicles.Find(v => v.LicensePlate == plate);

            if (vehicle != null)
            {
                // 2. Calculate the time elapsed
                // We subtract EntryTime from the current time
                TimeSpan duration = DateTime.Now - vehicle.EntryTime;

                // 3. Calculate the total cost
                // We use TotalMinutes for easier testing
                decimal totalToPay = (decimal)duration.TotalMinutes * HourlyRate;

                // 4. Free up the space
                CurrentVehicles.Remove(vehicle);

                Console.WriteLine($"\n--- Exit Receipt ---");
                Console.WriteLine($"Plate: {vehicle.LicensePlate}");
                Console.WriteLine($"Time Parked: {duration.Minutes} minutes");
                Console.WriteLine($"Total to Pay: ${totalToPay:F2}");
                Console.WriteLine($"--------------------");
            }
            else
            {
                Console.WriteLine($"Error: Vehicle with plate {plate} not found.");
            }
        }
    }
}