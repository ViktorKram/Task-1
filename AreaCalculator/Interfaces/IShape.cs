using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Interfaces
{
    /// <summary>
    /// Exposes the method "CalculateArea", which returns area of a shape in 'double' type.
    /// </summary>
    interface IShape
    {
        // Объявим метод для определения площади фигуры.
        double CalculateArea();
    }
}
