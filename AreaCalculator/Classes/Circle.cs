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
        // Объявим закрытую переменную для хранения значения радиуса круга.
        private readonly double _radius;
        #endregion

        #region Constructors
        // Объявим констуктор класса Circle, принимающий значение для _radius.
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentOutOfRangeException("Radius", "Radius equals or less than 0.");
            else if (Double.IsPositiveInfinity(radius))
                throw new ArgumentException("Radius is positive infinity.");
            else if (Double.IsNaN(radius))
                throw new ArgumentException("Radius is NaN.");

            _radius = radius;
        }
        #endregion

        #region Properties
        // Объявим открытое свойство для получения значения радиуса круга. 
        public double Radius => _radius;
        #endregion

        #region Methods
        // Реализуем метод CalculateArea, унаследованный от интерфейса IShape.
        /// <summary>
        /// Returns a circle's area calculated by radius.
        /// </summary>
        /// <returns>The number calculated by special math formula.</returns>
        public double CalculateArea() => Math.Pow(_radius, 2) * Math.PI;
        #endregion
    }
}
