using System;

namespace Sandbox
{
    class Vehicle
    {
        private string _color;
        private double _speed;
        private double _weight;
        private double _payloadCapacity;
        private Dimension _dimensions;

        public Vehicle() {}

        public Vehicle(
            string color,
            double speed,
            double weight,
            double payloadCapacity,
            Dimension dimensions
        )
        {
            _color = color;
            _speed = speed;
            _weight = weight;
            _payloadCapacity = payloadCapacity;
            _dimensions = dimensions;
        }

        public string GetColor()
        {
            return _color;
        }
        public double GetSpeed()
        {
            return _speed;
        }
        public double GetWeight()
        {
            return _weight;
        }
        public double GetPayloadCapacity()
        {
            return _payloadCapacity;
        }
        public Dimension GetDimensions()
        {
            return _dimensions;
        }

        public void SetColor(string color)
        {
            _color = color;
        }
        public void SetSpeed(double speed)
        {
            _speed = speed;
        }
        public void SetWeight(double weight)
        {
            _weight = weight;
        }
        public void SetPayloadCapacity(double payloadCapacity)
        {
            _payloadCapacity = payloadCapacity;
        }
        public void SetDimensions(Dimension dimensions)
        {
            _dimensions = dimensions;
        }

        public static void Moving()
        {
            Console.WriteLine("The vehicle is moving");
        }
    }
}