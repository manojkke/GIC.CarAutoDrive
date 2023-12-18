
namespace GIC.AutoDrivingCar.DomainTest
{
    public class CarMovementTests
    {
        [Fact]
        public void Car_Moves_Forward_North()
        {
            // Arrange
            var car = new Car(1, 2, FacingDirection.North);
            var field = new Field(10, 10);
            var service = new CarCommandService(field);

            // Act
            service.ExecuteCommands(car, "F");

            // Assert
            Assert.Equal(1, car.X);
            Assert.Equal(3, car.Y);
            Assert.Equal(FacingDirection.North, car.Direction);
        }

        [Fact]
        public void Car_Moves_Forward_West()
        {
            var car = new Car(3, 2, FacingDirection.West);
            var field = new Field(10, 10);
            var service = new CarCommandService(field);

            service.ExecuteCommands(car, "F");

            Assert.Equal(2, car.X);
            Assert.Equal(2, car.Y);
            Assert.Equal(FacingDirection.West, car.Direction);
        }

        [Fact]
        public void Car_Moves_Forward_South()
        {
            var car = new Car(1, 2, FacingDirection.South);
            var field = new Field(10, 10);
            var service = new CarCommandService(field);

            service.ExecuteCommands(car, "F");

            Assert.Equal(1, car.X);
            Assert.Equal(1, car.Y);
            Assert.Equal(FacingDirection.South, car.Direction);
        }

        [Fact]
        public void Car_Moves_Forward_East()
        {
            var car = new Car(1, 2, FacingDirection.East);
            var field = new Field(10, 10);
            var service = new CarCommandService(field);

            service.ExecuteCommands(car, "F");

            Assert.Equal(2, car.X);
            Assert.Equal(2, car.Y);
            Assert.Equal(FacingDirection.East, car.Direction);
        }

    }
}