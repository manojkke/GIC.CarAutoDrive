using GIC.AutoDrivingCar.Domain.ValueObjects;

namespace GIC.AutoDrivingCar.Application.Interface
{
    interface ICarCommandService
    {
        void ExecuteCommands(Car car, string commands);
    }
}
