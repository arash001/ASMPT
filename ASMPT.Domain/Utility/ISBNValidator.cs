using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPT.Domain.Utility
{
    using System;

    public static class ISBNValidator
    {
        public static bool IsValidISBN(string isbn)
        {
            // Remove any hyphens or spaces in the ISBN
            isbn = isbn.Replace("-", "").Replace(" ", "");

            if (isbn.Length == 10)
            {
                return IsValidISBN10(isbn);
            }
            else if (isbn.Length == 13)
            {
                return IsValidISBN13(isbn);
            }
            else
            {
                return false; // ISBN must be either 10 or 13 digits
            }
        }

        private static bool IsValidISBN10(string isbn)
        {
            int checksum = 0;
            for (int i = 0; i < 9; i++)
            {
                int digit;
                if (int.TryParse(isbn[i].ToString(), out digit))
                {
                    checksum += (i + 1) * digit;
                }
                else
                {
                    return false; // Invalid character found
                }
            }

            if (isbn[9] == 'X')
            {
                checksum += 10;
            }
            else
            {
                int lastDigit;
                if (int.TryParse(isbn[9].ToString(), out lastDigit))
                {
                    checksum += lastDigit;
                }
                else
                {
                    return false; // Invalid character found
                }
            }

            return checksum % 11 == 0;
        }

        private static bool IsValidISBN13(string isbn)
        {
            int checksum = 0;
            for (int i = 0; i < 12; i++)
            {
                int digit;
                if (int.TryParse(isbn[i].ToString(), out digit))
                {
                    checksum += (i % 2 == 0) ? digit : digit * 3;
                }
                else
                {
                    return false; // Invalid character found
                }
            }

            int lastDigit;
            if (int.TryParse(isbn[12].ToString(), out lastDigit))
            {
                return (10 - (checksum % 10)) % 10 == lastDigit;
            }
            else
            {
                return false; // Invalid character found
            }
        }
    }
}

