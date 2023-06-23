using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CatManagementProject
{
    internal class Utils
    {
        public static bool isValidUsername(string txtUsername, string format)
        {
            bool isValid = false;

            if (!String.IsNullOrEmpty(txtUsername))
            {
                if (Regex.IsMatch(txtUsername, format))
                {
                    isValid = true;
                }
            }

            return isValid;
        }

        public static bool isValidPassword(string txtPassword, string format)
        {
            bool isValid = false;

            if (!String.IsNullOrEmpty(txtPassword))
            {
                if (Regex.IsMatch(txtPassword, format))
                {
                    isValid = true;
                }
            }

            return isValid;
        }
            
        public static bool isValidFullname(string txtFullname)
        {
            bool isValid = false;

            if (!String.IsNullOrEmpty(txtFullname))
            {
                if (txtFullname.All(c => char.IsLetter(c) || c == ' '))
                {
                    isValid = true;
                }
            }

            return isValid;
        }
    }
}
