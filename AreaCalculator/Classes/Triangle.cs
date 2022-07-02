using System;
using AreaCalculator.Interfaces;

namespace AreaCalculator.Classes
{
    /// <summary>
    /// Public class Triangle inherits IShape interface.
    /// </summary>
    public class Triangle : IShape
    {
        #region Vars
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;
        #endregion

        #region Constructors
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentOutOfRangeException("side", "Side equals or less than 0.");

            else if (Double.IsPositiveInfinity(sideA) || Double.IsPositiveInfinity(sideB) || Double.IsPositiveInfinity(sideC))
                throw new ArgumentException("Side is positive infinity.");

            else if (Double.IsNaN(sideA) || Double.IsNaN(sideB) || Double.IsNaN(sideC))
                throw new ArgumentException("Side is NaN.");

            else if (sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideA + sideB)
                throw new ArgumentOutOfRangeException("side", "Triangle with these sides cannot exist.");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        #endregion

        #region Properties
        public double SideA => _sideA;
        public double SideB => _sideB;
        public double SideC => _sideC;
        #endregion

        #region Methods
        /// <summary>
        /// Returns a triangle's area calculated by sides lengths.
        /// </summary>
        /// <returns>The number calculated by special math formula.</returns>
        public double CalculateArea()
        {
            var halfPerimetr = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt((halfPerimetr - _sideA) * (halfPerimetr - _sideB) * (halfPerimetr - _sideC) * halfPerimetr);
        }

        /// <summary>
        /// Returns a bool value if the Triangle object has a right angle.
        /// </summary>
        /// <returns></returns>
        public bool HasRightAngle()
        {
            return (_sideA == Math.Sqrt(Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2))
                    || _sideB == Math.Sqrt(Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2))
                    || _sideC == Math.Sqrt(Math.Pow(_sideB, 2) + Math.Pow(_sideA, 2)));
        }
        #endregion
    }
}
