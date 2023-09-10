using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodeGenerator
{
    internal class OTPCreator
    {
        public static string Create(int from, int to)
        {
            string OTPCode = null;
            Random rnd = new Random();
            //'from' and 'to' used for detemining how many digits random number creates:
            OTPCode = rnd.Next(from, to).ToString();
            return OTPCode;
        }
    }
}
