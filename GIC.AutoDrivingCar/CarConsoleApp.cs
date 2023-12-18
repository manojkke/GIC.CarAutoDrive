using GIC.AutoDrivingCar.Application.Implementation;
using GIC.AutoDrivingCar.Application.Interface;
using GIC.AutoDrivingCar.Domain.Enums;
using GIC.AutoDrivingCar.Domain.ValueObjects;
using GIC.AutoDrivingCar.Infrastructure.Models; 

namespace GIC.AutoDrivingCar.ConsoleApp
{
    public class CarConsoleApp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("< < < = = = = = = = = = = = = = = = = = = = = = = = = > > >");
            Console.WriteLine("GIC Autonomous Car Prototype!");
            Console.WriteLine("< < < = = = = = = = = = = = = = = = = = = = = = = = = > > >");

            bool isRunning = true;

            while (isRunning)
            {
                try
                {
                    // Get field dimensions
                    Console.Write("Enter field width: ");
                    int fieldWidth = int.Parse(Console.ReadLine());
                    Console.Write("Enter field height: ");
                    int fieldHeight = int.Parse(Console.ReadLine());

                    // Get initial car position and direction
                    Console.Write("Enter car position (X,Y): ");
                    string positionStr = Console.ReadLine();
                    int carX = int.Parse(positionStr.Split(',')[0]);
                    int carY = int.Parse(positionStr.Split(',')[1]);
                    Console.Write("Enter car facing direction (North, East, South, West): ");
                    FacingDirection direction = Enum.Parse<FacingDirection>(Console.ReadLine(), true);

                    // Get command sequence
                    Console.Write("Enter command sequence (F, L, R): ");
                    string commands = Console.ReadLine().ToUpper();

                    // Create car and field objects
                    Car car = new Car(carX, carY, direction);
                    Field field = new Field(fieldWidth, fieldHeight);
                    ICarCommandService service = new CarCommandService(field);

                    // Execute commands
                    service.ExecuteCommands(car, commands);


                    Console.WriteLine("< < < = = = = = = = = = = = = = = = = = = = = = = = = > > >");
                    Console.WriteLine("GIC Autonomous Car Output");
                    Console.WriteLine("< < < = = = = = = = = = = = = = = = = = = = = = = = = > > >");

                    // Print final car state
                    Console.WriteLine($"Car position: ({car.X}, {car.Y})");
                    Console.WriteLine($"Car direction: {car.Direction}");

                    // Continue or exit
                    Console.WriteLine("\nPress Enter to continue, or Q to quit.");
                    string input = Console.ReadLine().ToUpper();
                    isRunning = !input.Equals("Q");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine("Exiting Car Prototype...");
        }
    }

}

