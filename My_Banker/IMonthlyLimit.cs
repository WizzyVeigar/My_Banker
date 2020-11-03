using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    interface IMonthlyLimit
    {
        /// <summary>
        /// Monthly Limit for how much you can spend on a given Item
        /// </summary>
        float MonthlyLimit { get; set; }
    }
}
