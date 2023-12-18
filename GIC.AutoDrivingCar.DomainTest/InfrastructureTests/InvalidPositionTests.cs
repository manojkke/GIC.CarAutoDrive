using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIC.AutoDrivingCar.Infrastructure.Models;

namespace GIC.AutoDrivingCar.UnitTests.Infrastructure
{
    public class InvalidPositionTests
    {
        [Fact]
        public void Field_Identifies_Invalid_Position()
        {
            var field = new Field(10, 10);

            Assert.False(field.IsValidPosition(new Car(11, 3, FacingDirection.East)));
        }

    }
}
