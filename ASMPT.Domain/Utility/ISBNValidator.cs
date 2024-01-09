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
            string cleanedISBN = new string(isbn.Where(char.IsDigit).ToArray());

            if (cleanedISBN.Length == 10)
            {
                return IsValidISBN10(cleanedISBN);
            }
            else if (cleanedISBN.Length == 13)
            {
                return IsValidISBN13(cleanedISBN);
            }
            else
            {
                return false; 
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
                    return false; 
                }
            }

            char lastChar = isbn[9];
            if (lastChar == 'X' || lastChar == 'x')
            {
                checksum += 10;
            }
            else
            {
                int lastDigit;
                if (int.TryParse(lastChar.ToString(), out lastDigit))
                {
                    checksum += lastDigit;
                }
                else
                {
                    return false; 
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
                    return false; 
                }
            }

            int lastDigit;
            if (int.TryParse(isbn[12].ToString(), out lastDigit))
            {
                return (10 - (checksum % 10)) % 10 == lastDigit;
            }
            else
            {
                return false; 
            }
        }
    }


}

