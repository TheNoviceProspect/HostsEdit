using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokerApi
{
    /// <summary>
    /// Class JokerHelper.
    /// </summary>
    /// <seealso cref="JokerApi.IJokerHelper" />
public class JokerHelper : IJokerHelper
    {
        /// <summary>
        /// Adds the specified Num1.
        /// </summary>
        /// <param name="Num1">The Num1.</param>
        /// <param name="Num2">The num2.</param>
        /// <returns>System.Int32.</returns>
        public int AddNums(int Num1, int Num2)
        {
            var result = Num1 + Num2;
            return result;
        }

        /// <summary>
        /// Divs the specified Num1.
        /// </summary>
        /// <param name="Num1">The Num1.</param>
        /// <param name="Num2">The Num2.</param>
        /// <returns>System.Int32.</returns>
        public int DivNums(int Num1, int Num2)
        {
            var result = Num1 / Num2;
            return result;
        }

        /// <summary>
        /// Muls the specified Num1.
        /// </summary>
        /// <param name="Num1">The Num1.</param>
        /// <param name="Num2">The Num2.</param>
        /// <returns>System.Int32.</returns>
        public int MulNums(int Num1, int Num2)
        {
            var result = Num1 * Num2;
            return result;
        }

        /// <summary>
        /// Subs the specified Num1.
        /// </summary>
        /// <param name="Num1">The Num1.</param>
        /// <param name="Num2">The Num2.</param>
        /// <returns>System.Int32.</returns>
        public int SubNums(int Num1, int Num2)
        {
            var result = Num1 + Num2;
            return result;
        }
    }
}
