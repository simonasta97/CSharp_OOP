using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    internal class Box
    {
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght,double width,double height)
        {
            this.Lenght = lenght;
            this.Height = height;
            this.Width = width;
        }

        public double Lenght
        {
            get => this.lenght;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
                this.lenght = value;
            }
        }
        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public string SurfaceArea()
        {
            
            double result = 2 * this.Lenght * this.Width + 2 * this.Lenght * this.Height + 2 * this.Width * this.Height;
            return $"Surface Area - {result:F2}";
        }
        public string Lateral()
        {

            double result = 2 * this.Lenght * this.Height + 2 * this.Width * this.Height;
            return $"Lateral Surface Area - {result:F2}";
        }
        public string Volume()
        {
            double result = this.Lenght * this.Width * this.Height;
            return $"Volume - {result:F2}";
        }
    }
}
