using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodeGenerator
{
    internal class CreateOderNumber
    {
        /// <summary>
        /// Create random and unique number code.
        /// </summary>
        /// <param name="initials">it's optional; if you want your order number starts with special caharacters.</param>
        /// <param name="length">length of unique random code that generated. </param>
        /// <returns></returns>
        public static string Create(string initials, int length = 8)
        {
            string OrderNO = string.Empty;
            using (RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider())
            {
                byte[] rno = new byte[5];
                rg.GetBytes(rno);
                int randomvalue = BitConverter.ToInt32(rno, 0);

                byte[] rno1 = new byte[5];
                RandomNumberGenerator.Create().GetBytes(rno1);
                int randomvalue1 = BitConverter.ToInt32(rno1, 0);

                Console.WriteLine(Math.Abs(randomvalue));
                Console.WriteLine(Math.Abs(randomvalue1));

                OrderNO = Generator(Math.Abs(randomvalue), length);
                OrderNO = !string.IsNullOrEmpty(initials) ? initials + OrderNO : OrderNO;
            }

            return OrderNO;
        }
        internal static string Generator(int randomNo, int length)
        {
            string OrderNO = (2 * DateTime.Now.Month + DateTime.Now.Day + +DateTime.Now.Minute + 3 * DateTime.Now.Second + 7 + DateTime.Now.Millisecond + randomNo).ToString().Substring(0, length);
            return OrderNO;
        }
    }
}
