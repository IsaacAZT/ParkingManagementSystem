using System;

namespace ParkingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Initialize our parking with a capacity of 10
            Parking myParking = new Parking(10);
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Parking Management System ---");
                Console.WriteLine("1. Enter Vehicle");
                Console.WriteLine("2. Exit Vehicle (Checkout)");
                Console.WriteLine("3. Exit Program");
                Console.Write("Select an option: ");

                string option = Console.ReadLine()??"";

                switch (option)
                {
                    case "1":
                        Console.Write("Enter license plate: ");
                        string plateIn = Console.ReadLine() ?? "";
                        Vehicle newVehicle = new Vehicle(plateIn);
                        myParking.AddVehicle(newVehicle);
                        break;

                    case "2":
                        Console.Write("Enter license plate to exit: ");
                        string plateOut = Console.ReadLine() ?? "";
                        myParking.RemoveVehicle(plateOut);
                        break;

                    case "3":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}