using System;
using System.Text.RegularExpressions;

namespace AdditionalСhecks
{
    static public class StringExtension
    {
        /// <summary>
        /// Get time from string in format hh:mm.
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns>Time in format hh:mm</returns>
        public static string GetTime(this string str)
        {
            Regex rg = new Regex(@"([0-1]\d|2[0-3]):([0-5]\d)");
            var result = rg.Match(str);
            return result.Value;
        }
        /// <summary>
        /// Checks if the entered string is a Mac address.
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns></returns>
        public static bool IsMacAdress(this string str)
        {
            return Regex.IsMatch(str, @"^(([0-9a-fA-F]{2}):){5}([0-9a-fA-F]{2})$");
        }
        /// <summary>
        /// Checks if the entered string is an email address.
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns></returns>
        public static bool IsEmailAdress(this string str)
        {
            return Regex.IsMatch(str, @"([\w]+)@([\w]{1,63}\.?[\w]{1,63})");
        }
        /// <summary>
        /// Checks if the entered password is strong.
        /// </summary>
        /// <param name="str">Input string</param>
        /// <returns></returns>
        public static bool IsStrongPassword(this string str)
        {
            return Regex.IsMatch(str, @"(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])[\w-]{8,}");
        }
    }
}
