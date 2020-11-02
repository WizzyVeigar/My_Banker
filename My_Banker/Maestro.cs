using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    class Maestro : BaseCard, IExpire
    {
        private DateTime expirationDate;
        public DateTime ExpirationDate
        {
            get
            {
                return expirationDate;
            }

            set
            {
                expirationDate = value;
            }
        }
        

        public Maestro(string cardHolder) : base(cardHolder)
        {
            CardName = "Maestro";
            int[] arr = new int[] { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };
            CardPrefix = arr[new Random().Next(0, arr.Length)].ToString();
            CardNumber = NumberGenerator.Instance.GenerateNumbers(19, CardPrefix);
            ExpirationDate = DateTime.Now.AddYears(5).AddMonths(8);

        }


        public override string RetrieveInformation()
        {
            return base.RetrieveInformation() + "\n" +
                "Expiration Date: " + ExpirationDate.ToShortDateString() + "\n";
        }
    }
}
