using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIC.AutoDrivingCar.Infrastructure.Models;

namespace GIC.AutoDrivingCar.UnitTests.Infrastructure
{
    public class ValidPositionTests
    {
        [Fact]
        public void Field_Identifies_Valid_Position()
        {
            var field = new Field(10, 10);

            Assert.True(field.IsValidPosition(new Car(5, 3, FacingDirection.East)));
        }

    }
}
