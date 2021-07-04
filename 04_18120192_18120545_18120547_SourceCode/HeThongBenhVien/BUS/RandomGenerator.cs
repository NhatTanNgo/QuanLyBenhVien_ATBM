using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RandomGenerator
    {
        private static Random _instance = null;
        public static Random Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Random();
                }
                return _instance;
            }
        }

        public static String RandomString (int size)
        {
            var builder = new StringBuilder(size);
            const String alphabet = "abcdefghijklmnoprstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            int c = 0;
            for(int i = 0; i < size; i++)
            {
                c = Instance.Next(alphabet.Length);
                builder.Append(alphabet[c]);
            }    
            return builder.ToString();
        }

    }
}
