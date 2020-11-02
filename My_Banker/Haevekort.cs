using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    class Haevekort : BaseCard
    {
        public Haevekort(string cardHolder) : base(cardHolder)
        {
            CardName = "Hævekort";
            CardPrefix = "2400";
            CardNumber = NumberGenerator.Instance.GenerateNumbers(16, CardPrefix);
        }
    }
}
