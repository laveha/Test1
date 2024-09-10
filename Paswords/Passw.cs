using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Paswords
{
    public class Passw
    {
        public static int CheckPasw(string pasw)
        {
            int score = 0;

            if (Regex.IsMatch(pasw, @"\d"))
                score++;

            if (Regex.IsMatch(pasw, @"[a-z]"))
                score++;

            if (Regex.IsMatch(pasw, @"[A-Z]"))
                score++;

            if (Regex.IsMatch(pasw, @"[\W_]"))
                score++;

            if (pasw.Length > 10)
                score++;

            return score;
        }
    }
}
