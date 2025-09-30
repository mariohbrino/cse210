using System;

namespace Sandbox
{
    class Airplane : Vehicle
    {
        private double _maxAltitude;

        public Airplane() {}

        public Airplane(
            double maxAltitude,
            string color,
            double speed,
            double weight,
            double payloadCapacity,
            Dimension dimensions
        ) : base(color, speed, weight, payloadCapacity, dimensions)
        {
            _maxAltitude = maxAltitude;
        }

        public double GetMaxAltitude()
        {
            return _maxAltitude;
        }

        public void SetMaxAltitude(double maxAltitude)
        {
            _maxAltitude = maxAltitude;
        }

        public void Flying()
        {
            Moving();
            Console.WriteLine("The airplane is flying");
        }
    }
}