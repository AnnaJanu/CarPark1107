﻿namespace CarParkProject_0506.Data
{
    public class Chassis
    {
        public ushort NumberOfWheels { get; set; }

        public string? Number { get; set; }

        public float PermissibleLoad { get; set; }

        public override string ToString()
        {
            return $"NumberOfWheels:{NumberOfWheels}\nNumber:{Number}\nPermissibleLoad:{PermissibleLoad}";
        }
    }
}