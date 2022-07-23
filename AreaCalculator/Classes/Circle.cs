using System;
using AreaCalculator.Interfaces;

namespace AreaCalculator.Classes
{
    /// <summary>
    /// Public class Circle inherits IShape interface.
    /// </summary>
    public class Circle : IShape
    {
        #region Vars
        private readonly double _radius;
        #endregion

        #region Constructors
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "Parameter equals or less than 0.");

            if (Double.IsPositiveInfinity(radius))
                throw new ArgumentException("Parameter is positive infinity.", nameof(radius));

            if (Double.IsNaN(radius))
                throw new ArgumentException($"Parameter is NaN.", nameof(radius));

            _radius = radius;
        }
        #endregion

        #region Properties 
        public double Radius => _radius;
        #endregion

        #region Methods
        /// <summary>
        /// Returns a circle's area calculated by radius.
        /// </summary>
        /// <returns>The number calculated by special math formula.</returns>
        public double CalculateArea() => Math.Pow(_radius, 2) * Math.PI;
        #endregion
    }
}
