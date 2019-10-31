using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Models
{
    public class UtilityService
    {
        private readonly List<string> colors;
        private readonly Random random;

        public UtilityService()
        {
            colors = new List<string>
        {
            "red",
            "blue",
            "lime",
            "orange",
            "magenta"
        };

            random = new Random();
        }

        public string RandomColor()
        {
            return colors[random.Next(colors.Count)];
        }
        public List<string> ValidateEmail(string email)
        {
            string isValid;
            string color;
            List<string> combo = new List<string>();
            if (email.Contains("@") && email.Contains("."))
            {
                isValid = email + " is a valid e-mail.";
                color = "green";
            }
            else
            {
                isValid = email + " is not a valid e-mail.";
                color = "red";
            }
            combo.Add(isValid);
            combo.Add(color);
            return combo;
        }
    }
}
