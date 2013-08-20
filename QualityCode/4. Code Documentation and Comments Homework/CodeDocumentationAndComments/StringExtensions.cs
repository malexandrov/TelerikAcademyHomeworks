namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// String extension methods class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a binary input string to MD5 Hash using the .NET HashAlgorithm.
        /// <see cref="System.Security.Cryptography.HashAlgorithm"></see>
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>Returns the hexadecimal of the input as a string.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }
       
        /// <summary>
        /// Checks if the input string can be interpreted as Boolean "true" value.
        /// <para>For more information check <see cref="System.Boolean"/> </para>
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>If sucessfull returns "True".</returns>
        public static bool ToBoolean(this string input)
        {
            // Define an array with values to be evaluated as "true"
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Parses a string to short variable type (Signed 16-bit integer).
        /// <see cref="System.Int16"/>
        /// </summary>
        /// <param name="input">The string to be parsed to "short" variable type.</param>
        /// <returns>Returns the input as a Signed 16-bit integer.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// A method that converts a string value to integer variable type (Signed 32-bit integer).
        /// <see cref="System.Int32"/>
        /// </summary>
        /// <param name="input">The string to be parsed to "int" variable type.</param>
        /// <returns>Returns the input as a Signed 32-bit integer.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// A method that converts a string value to a long integer variable type (Signed 64-bit integer).
        /// <see cref="System.Int64"/>
        /// </summary>
        /// <param name="input">The string to be parsed to "int" variable type.</param>
        /// <returns>Returns the input as a Signed 64-bit integer.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// A method that converts an input string value to a DateTime structure.
        /// <see cref="System.DateTime"/>
        /// </summary>
        /// <param name="input">The string to be parsed to DateTime type.</param>
        /// <returns>Returns the input as a DateTime.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Returns a copy of the input with capitalized first letter.
        /// </summary>
        /// <param name="input">This string.</param>
        /// <returns>Returns the input with capitalized first letter.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            // Return the unchanged input if it is null
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            
            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Returns a substring which is between <paramref name="startString"/>
        /// and <paramref name="endString"/>. Search starts from the <paramref name="startFrom"/> index.
        /// </summary>
        /// <param name="input">This string.</param>
        /// <param name="startString">The left delimiter of the resulting string.</param>
        /// <param name="endString">The right delimiter of the resulting string.</param>
        /// <param name="startFrom">The start position of the search. If none typed defaults to 0</param>
        /// <returns>A string that is equivalent to the substring between <paramref name="startString"/>
        /// and <paramref name="endString"/> or System.String.Empty if <paramref name="startString"/> or 
        /// <paramref name="endString"/> don't occur within this instance.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Replaces all cyrillic letters in the string with their latin equivalent. Works with lowercase and uppercase.
        /// </summary>
        /// <param name="input">This string.</param>
        /// <returns>Returns a string value.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Replaces all latin letters within the string with their cyrillic keyboard representation. Works with lowercase and uppercase.
        /// </summary>
        /// <param name="input">This string.</param>
        /// <returns>Returns a string value.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// A method that corrects invalid username string input by converting cyrillic letters to latin and removing forbidden characters.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>Returns a string with only latin alphanumerical characters and underscore.</returns>
        /// <example>
        /// This sample shows how to call the <see cref="ToValidUsername"/> method.
        /// <code>
        /// class TestClass
        /// {
        /// static void Main()
        /// {
        /// string value = "Пешо_123-";
        /// Console.WriteLine(value.ToValidUsername());
        /// }
        /// }
        /// </code>
        /// The output returns "Pesho_123".
        /// </example>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// A method that corrects invalid latin filename input by converting cyrillic letters to latin and removing forbidden characters.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>Returns a string with only latin alphanumerical characters, "-" and "_".</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Returns a substring of <paramref name="charsCount"/> characters that starts from the beginning.
        /// </summary>
        /// <param name="input">This instance.</param>
        /// <param name="charsCount">The number of characters to return.</param>
        /// <returns>Returns a string containing the first  <paramref name="charsCount"/> characters.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// A method that returns the extension of the input filename string (substring after the ".").
        /// </summary>
        /// <param name="fileName">This instance.</param>
        /// <returns>Returns a string containing the extension.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// A method that returns the corresponding content type for the input file extension.
        /// </summary>
        /// <param name="fileExtension">The file extension (excluding the period ".").</param>
        /// <returns>Returns a string value.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts an input string into a sequence of bytes.
        /// </summary>
        /// <param name="input">The string to convert.</param>
        /// <returns>Returns a byte[] array containing the binary representation of the input.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
