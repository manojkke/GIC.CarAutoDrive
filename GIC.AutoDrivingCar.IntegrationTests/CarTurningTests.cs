namespace GIC.AutoDrivingCar.Tests
{
    public class CarTurningTests
    {
        [Fact]
        public void Car_Turns_Left_North()
        {
            var car = new Car(1, 2, FacingDirection.North);
            var field = new Field(10, 10);
            var service = new CarCommandService(field);

            service.ExecuteCommands(car, "L");

            Assert.Equal(1, car.X);
            Assert.Equal(2, car.Y);
            Assert.Equal(FacingDirection.West, car.Direction);
        }

        [Fact]
        public void Car_Turns_Left_West()
        {
            var car = new Car(3, 2, FacingDirection.West);
            var field = new Field(10, 10);
            var service = new CarCommandService(field);

            service.ExecuteCommands(car, "L");

            Assert.Equal(3, car.X);
            Assert.Equal(2, car.Y);
            Assert.Equal(FacingDirection.South, car.Direction);
        }
    }
}
