using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace AssessSystem.Domain.Utilities
{
    public class TokenGenerator
    {
        public static string GenerateToken()
        {
            //http://stackoverflow.com/questions/938031/implementing-secure-unique-single-use-activation-urls-in-asp-net-c/938076#938076

            var random = new RNGCryptoServiceProvider();
            byte[] data = new byte[32];
            random.GetBytes(data);

            //removes everything thats not alphanumeric
           return Regex.Replace(Convert.ToBase64String(data), @"([^\w]|_)", String.Empty, RegexOptions.None);

        }
    }
}
