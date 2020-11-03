using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    class Visa : BaseCard, IExpire
    {

        public Visa(string cardHolder) : base(cardHolder)
        {
            CardName = "Visa";
            CardNumber = NumberGenerator.Instance.GenerateNumbers(16, "4");
            ExpirationDate = DateTime.Now.AddYears(5);
        }

        private DateTime expirationDate;
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }


        public override string RetrieveInformation()
        {
            return base.RetrieveInformation() + "\n" +
                "Expiration Date: " + ExpirationDate.ToShortDateString() + "\n";
        }
    }
}
