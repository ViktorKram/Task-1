using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Interfaces
{
    /// <summary>
    /// Defines a method to calculate IShape object's area.
    /// </summary>
    interface IShape
    {
        #region Methods
        // Объявим метод для определения площади фигуры.
        /// <summary>
        /// Returns a number which is the area of the shape.
        /// </summary>
        /// <returns></returns>
        double CalculateArea();
        #endregion
    }
}
