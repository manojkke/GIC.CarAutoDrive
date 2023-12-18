using GIC.AutoDrivingCar.Domain.ValueObjects;

namespace GIC.AutoDrivingCar.Infrastructure.Models
{
    public class Field
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Field(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool IsValidPosition(Car car) => car.X >= 0 && car.X < Width && car.Y >= 0 && car.Y < Height;
    }
}
