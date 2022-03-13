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
                throw new ArgumentOutOfRangeException("Radius", "Radius must be over 0.");
            else if (Double.IsPositiveInfinity(radius))
                throw new ArgumentException("Radius is positive infinity.");
            else if (Double.IsNaN(radius))
                throw new ArgumentException("Radius is NaN.");

            _radius = radius;
        }
        #endregion

        #region Properties
        // Объявим открытое свойство для получения значения радиуса круга. 
        public double Radius
        {
            get
            {
                return _radius;
            }
        }
        #endregion

        #region Methods
        // Реализуем метод CalculateArea, унаследованный от интерфейса IShape.
        /// <summary>
        /// Calculate the shape's area.
        /// </summary>
        /// <returns>The Circle area.</returns>
        public double CalculateArea()
        {
            return _radius * _radius * Math.PI;
        }
        #endregion
    }
}
