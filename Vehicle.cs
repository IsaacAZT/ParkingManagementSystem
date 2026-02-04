using System;

namespace ParkingManagementSystem
{
    // We use 'public' so other classes can access it
    public class Vehicle
    {
        // Attributes (Properties)
        public string LicensePlate { get; set; }
        public DateTime EntryTime { get; set; }
        public string Status { get; set; }

        // Constructor: Triggered when creating the object 'new Vehicle("ABC-123")'
        public Vehicle(string plate)
        {
            LicensePlate = plate;
            // DateTime.Now captures the exact system time at this moment
            EntryTime = DateTime.Now;
            Status = "Parked";
        }
    }
}