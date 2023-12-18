using GIC.AutoDrivingCar.Domain.ValueObjects;

namespace GIC.AutoDrivingCar.Application.Interface
{
    public interface ICarCommandService
    {
        void ExecuteCommands(Car car, string commands);
    }
}
