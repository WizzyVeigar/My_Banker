using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    class VISAElectron : BaseCard, IExpire, IMonthlyLimit
    {
        //BaseCard baseCard = new BaseCard();
        //4026, 417500, 4508, 4844, 4913, 4917
        //Visakort må expiry date ikke være større end 5 år
        //16 cifre kort

        public VISAElectron(string cardHolder) : base(cardHolder)
        {

            CardName = "Visa Electron";

            int[] arr = new int[] { 4026, 417500, 4508, 4844, 4913, 4917 };
            CardPrefix = arr[new Random().Next(0, arr.Length)].ToString();
            CardNumber = NumberGenerator.Instance.GenerateNumbers(16, CardPrefix);
            ExpirationDate = DateTime.Now.AddYears(5);
            MonthlyLimit = 10000f;
        }

        private DateTime expirationDate;

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }

        private float monthlyLimit;

        public float MonthlyLimit
        {
            get { return monthlyLimit; }
            set { monthlyLimit = value; }
        }


        public override string RetrieveInformation()
        {
            return base.RetrieveInformation() + "\n" +
                "Expiration Date: " + ExpirationDate.ToShortDateString() + "\n" +
                "Monthly Limit: " + MonthlyLimit + "\n";
        }
    }
}
