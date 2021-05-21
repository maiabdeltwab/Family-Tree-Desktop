using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FamilyTree
{
    internal static class Validation
    {
        #region regex validation

        private static readonly Regex nameReg =
            new Regex("^[ \u00c0-\u01ff\u0621-\u064A0-9 a-zA-Z'_-]{1,}$");

        private static readonly string[] genders
            = { "male", "female", "Male", "Female", "F", "M", "f", "m" };

        #endregion regex validation

        #region validation methods

        public static bool IsName(string name)
        {
            if (nameReg.IsMatch(name))
                return true;

            return false;
        }

        public static bool IsGender(string value)
        {
            if (genders.Contains(value))
                return true;

            return false;
        }

        #endregion validation methods
    }
}