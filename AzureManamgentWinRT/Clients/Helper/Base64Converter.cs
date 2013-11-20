using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureManamgentWinRT.Clients.Helper
{
    /// <summary>
    /// Base64 helper
    /// to convert strings to
    /// base64 representations
    /// and back.
    /// </summary>
    public class Base64Converter
    {
        /// <summary>
        /// Converts a string to a base64 representation.
        /// </summary>
        /// <param name="toConvert">To convert.</param>
        /// <returns></returns>
        public static string ToBase64(string toConvert)
        {
            if(!string.IsNullOrEmpty(toConvert) || !string.IsNullOrWhiteSpace(toConvert))
            {
                var base64Data = Convert.ToBase64String(Encoding.UTF8.GetBytes(toConvert));

                return base64Data;
            }

            return string.Empty;
        }

        /// <summary>
        /// Froms the base64.
        /// </summary>
        /// <param name="toConvert">To convert.</param>
        /// <returns></returns>
        public static string FromBase64(string toConvert)
        {
            if (!string.IsNullOrEmpty(toConvert) || !string.IsNullOrWhiteSpace(toConvert))
            {
                var bytes = Convert.FromBase64String(toConvert);
                var stringData = Encoding.UTF8.GetString(bytes,0,bytes.Length);

                return stringData;
            }

            return string.Empty;
        }
    }
}
