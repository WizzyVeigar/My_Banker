using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    interface ISpendingLimit
    {
        /// <summary>
        /// How much you are able to spend daily
        /// </summary>
        float SpendingLimit { get; set; }
    }
}
