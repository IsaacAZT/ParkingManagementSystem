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
                // Display the interactive menu 
                Console.WriteLine("\n--- Parking Management System ---");
                Console.WriteLine("1. Enter Vehicle");
                Console.WriteLine("2. Exit Vehicle (Checkout)");
                Console.WriteLine("3. Exit Program");
                Console.Write("Select an option: ");

                // Safety check for null inputs 
                string option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        // Registering a new vehicle 
                        Console.Write("Enter license plate: ");
                        string plateIn = Console.ReadLine() ?? "";
                        Vehicle newVehicle = new Vehicle(plateIn);
                        myParking.AddVehicle(newVehicle);
                        break;

                    case "2":
                        // Processing vehicle exit and checkout 
                        Console.Write("Enter license plate to exit: ");
                        string plateOut = Console.ReadLine() ?? "";
                        myParking.RemoveVehicle(plateOut);
                        break;

                    case "3":
                        // Controlled program exit 
                        Console.WriteLine("Exiting program... Goodbye!");
                        exit = true;
                        break;

                    default:
                        // Handling invalid menu selections 
                        Console.WriteLine("Invalid option. Please select 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}