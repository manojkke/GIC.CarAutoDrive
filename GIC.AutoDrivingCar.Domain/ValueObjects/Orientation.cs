using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GIC.AutoDrivingCar.Domain.Enums;

namespace GIC.AutoDrivingCar.Domain.ValueObjects
{
    public class Orientation
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Direction Facing { get; private set; }

        public Orientation(int x, int y, Direction facing)
        {
            X = x;
            Y = y;
            Facing = facing;
        }

        public Orientation MoveForward()
        {
            switch (Facing)
            {
                case Direction.North:
                    return new Orientation(X, Y + 1, Facing);
                case Direction.East:
                    return new Orientation(X + 1, Y, Facing);
                case Direction.South:
                    return new Orientation(X, Y - 1, Facing);
                case Direction.West:
                    return new Orientation(X - 1, Y, Facing);
                default:
                    return this; // Should not happen
            }
        }

        public Orientation RotateLeft()
        {
            return new Orientation(X, Y, (Direction)(((int)Facing + 3) % 4));
        }

        public Orientation RotateRight()
        {
            return new Orientation(X, Y, (Direction)(((int)Facing + 1) % 4));
        }
    }
