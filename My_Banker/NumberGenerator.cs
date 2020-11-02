using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace My_Banker
{
    public class NumberGenerator
    {
        private static NumberGenerator instance;

        public static NumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NumberGenerator();
                }
                return instance;
            }
        }


        public string GenerateNumbers(int digitCount, string prefix)
        {
            string cardnumbers = prefix;
            for (; cardnumbers.Length < digitCount;)
            {
                Thread.Sleep(25);
                cardnumbers += new Random().Next(0, 9).ToString();
            }
            return cardnumbers;
        }
    }
}
