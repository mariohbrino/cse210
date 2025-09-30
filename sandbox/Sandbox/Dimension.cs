using System;

namespace Sandbox
{
    class Dimension
    {
        private double _height;
        private double _width;
        private double _lenght;

        public Dimension(double height, double width, double lenght)
        {
            _height = height;
            _width = width;
            _lenght = lenght;
        }

        public double GetHeight()
        {
            return _height;
        }

        public double GetWidth()
        {
            return _width;
        }

        public double GetLenght()
        {
            return _lenght;
        }

        public void SetHeight(double height)
        {
            _height = height;
        }

        public void SetWidth(double width)
        {
            _width = width;
        }

        public void SetLenght(double lenght)
        {
            _lenght = lenght;
        }
    }
}
