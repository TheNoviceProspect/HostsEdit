using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerApi
{
    /// <summary>
    /// This defines some basic functions that every iteration of this library should have!
    /// </summary>
    public interface IJokerHelper
    {
        /// <summary>
        /// Adds the specified num1 and num2 somehow.
        /// </summary>
        /// <param name="Num1">The num1.</param>
        /// <param name="Num2">The num2.</param>
        /// <returns>System.Int32.</returns>
        int AddNums(int Num1, int Num2);
        /// <summary>
        /// Subtracts the specified num2 from num1 somehow.
        /// </summary>
        /// <param name="Num1">The num1.</param>
        /// <param name="Num2">The num2.</param>
        /// <returns>System.Int32.</returns>
        int SubNums(int Num1, int Num2);
        /// <summary>Muls the specified Num1.</summary>
        /// <param name="Num1">The Num1.</param>
        /// <param name="Num2">The Num2.</param>
        /// <returns>System.Int32.</returns>
        int MulNums(int Num1, int Num2);
        /// <summary>Divs the specified Num1.</summary>
        /// <param name="Num1">The Num1.</param>
        /// <param name="Num2">The Num2.</param>
        /// <returns>System.Int32.</returns>
        /// TODO: come up with a way to make division by 0 impossible before exception is thrown
        int DivNums(int Num1, int Num2);       

    }
}
