using System;

namespace ParkingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. We create the parking object with 10 spaces
            Parking myParking = new Parking(10);

            // 2. We create a new vehicle object
            Vehicle myCar = new Vehicle("ABC-123");

            // 3. We call the method to add the vehicle
            Console.WriteLine("--- Simulation Started ---");
            myParking.AddVehicle(myCar);

            // 4. We check if it was added to the list
            Console.WriteLine($"Vehicles currently in parking: {myParking.CurrentVehicles.Count}");

            // Wait for user to press a key before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}