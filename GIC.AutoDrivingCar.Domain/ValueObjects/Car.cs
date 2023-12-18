using GIC.AutoDrivingCar.Domain.Enums;

namespace GIC.AutoDrivingCar.Domain.ValueObjects
{
    public class Car : IPosition
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public FacingDirection Direction { get; private set; }

        public Car(int x, int y, FacingDirection direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        public void MoveForward()
        {
            switch (Direction)
            {
                case FacingDirection.North:
                    Y++;
                    break;
                case FacingDirection.East:
                    X++;
                    break;
                case FacingDirection.South:
                    Y--;
                    break;
                case FacingDirection.West:
                    X--;
                    break;
            }
        }

        public void TurnLeft()
        {
            Direction = Direction == FacingDirection.North ? FacingDirection.West :
                        Direction == FacingDirection.West ? FacingDirection.South :
                        Direction == FacingDirection.South ? FacingDirection.East :
                        FacingDirection.North;
        }

        public void TurnRight()
        {
            Direction = Direction == FacingDirection.North ? FacingDirection.East :
                        Direction == FacingDirection.East ? FacingDirection.South :
                        Direction == FacingDirection.South ? FacingDirection.West :
                        FacingDirection.North;
        }
    }
}
