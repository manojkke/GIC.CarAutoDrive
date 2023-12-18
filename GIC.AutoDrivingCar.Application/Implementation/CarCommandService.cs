using GIC.AutoDrivingCar.Application.Interface;
using GIC.AutoDrivingCar.Domain.ValueObjects;
using GIC.AutoDrivingCar.Infrastructure.Models;

namespace GIC.AutoDrivingCar.Application.Implementation
{
    public class CarCommandService : ICarCommandService
    {
        private readonly Field _field;

        public CarCommandService(Field field)
        {
            _field = field;
        }

        public void ExecuteCommands(Car car, string commands)
        {
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'F':
                        if (_field.IsValidPosition(car))
                        {
                            car.MoveForward();
                        }
                        break;
                    case 'L':
                        car.TurnLeft();
                        break;
                    case 'R':
                        car.TurnRight();
                        break;
                    default:
                        throw new InvalidOperationException($"Unknown command: {command}");
                }
            }
        }
    }
}
