﻿namespace XamarinIoTWorkshop
{
    public class AccelerometerDataModel
    {
        public AccelerometerDataModel(double x, double y, double z) => (X, Y, Z) = (x, y, z);

        public double X { get; }
        public double Y { get; }
        public double Z { get; }
    }
}
