using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIC.AutoDrivingCar.Domain.ValueObjects
{
    public class AutonomousCar
    {
        public Orientation CurrentOrientation { get; private set; }

        public AutonomousCar(Orientation initialOrientation)
        {
            CurrentOrientation = initialOrientation;
        }

        public void Move(string commands)
        {
            foreach (char command in commands)
            {
                ExecuteCommand(command);
            }
        }

        private void ExecuteCommand(char command)
        {
            CurrentOrientation = command switch
            {
                'L' => CurrentOrientation.RotateLeft(),
                'R' => CurrentOrientation.RotateRight(),
                'F' => CurrentOrientation.MoveForward(),
                _ => CurrentOrientation // Ignore unknown commands
            };
        }
    }
