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
        //Non thread safe singleton pattern
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

        /// <summary>
        /// Generates <paramref name="digitCount"/> random numbers with a <paramref name="prefix"/> in front
        /// </summary>
        /// <param name="digitCount"> How many numbers you want generated outside of prefix</param>
        /// <param name="prefix">The prefix to set in front of the random numbers</param>
        /// <returns>returns the random <paramref name="digitCount"/> long string, with <paramref name="prefix"/></returns>
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
