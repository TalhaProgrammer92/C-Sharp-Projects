using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Time_Table
{
    class AccountChecker
    {
        // If email is valid
        public static bool IsValidEmail(string email)
        {
            int score = 0;

            if (!Char.IsLetter(email[0]))
                return false;

            for (int i = 0; i < email.Length; i++)
            {
                if (email[i] == ' ')
                    return false;

                if (email[i] == '@' && score == 0)
                    score++;

                if (email[i] == '.' && score == 1 && email[i - 1] != '@')
                    score++;
            }

            return score == 2;
        }

        // If password is valid
        public static bool IsValidPassword(string password)
        {
            return password.Length >= 8 && !String.IsNullOrEmpty(password) && !String.IsNullOrWhiteSpace(password);
        }
    }
}
