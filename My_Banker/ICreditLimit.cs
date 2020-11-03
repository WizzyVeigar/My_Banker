using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    interface ICreditLimit
    {
        /// <summary>
        /// I'm not sure how credit works, but there's a limit
        /// </summary>
        float CreditLimit { get; set; }
    }
}
