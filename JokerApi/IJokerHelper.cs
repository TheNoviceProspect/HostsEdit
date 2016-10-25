using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerApi
{
    /// <summary>
    /// Interface IJokerHelper
    /// </summary>
    public interface IJokerHelper
    {
        /// <summary>
        /// Adds the specified num1 and num2 somehow.
        /// </summary>
        /// <param name="Num1">The num1.</param>
        /// <param name="Num2">The num2.</param>
        /// <returns>System.Int32.</returns>
        int Add(int Num1, int Num2);
        /// <summary>
        /// Subs the specified num1.
        /// </summary>
        /// <param name="Num1">The num1.</param>
        /// <param name="Num2">The num2.</param>
        /// <returns>System.Int32.</returns>
        int Sub(int Num1, int Num2);
        /// <summary>Muls the specified Num1.</summary>
        /// <param name="Num1">The Num1.</param>
        /// <param name="Num2">The Num2.</param>
        /// <returns>System.Int32.</returns>
        int Mul(int Num1, int Num2);
        /// <summary>Divs the specified Num1.</summary>
        /// <param name="Num1">The Num1.</param>
        /// <param name="Num2">The Num2.</param>
        /// <returns>System.Int32.</returns>
        int Div(int Num1, int Num2);
    }
}
