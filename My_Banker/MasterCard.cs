using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    class MasterCard : BaseCard, IExpire, ISpendingLimit, IMonthlyLimit, ICreditLimit
    {
        private DateTime expirationDate;

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set { expirationDate = value; }
        }


        private float spendingLimit;

        public float SpendingLimit
        {
            get { return spendingLimit; }
            set { spendingLimit = value; }
        }

        private float monthlyLimit;

        public float MonthlyLimit
        {
            get { return monthlyLimit; }
            set { monthlyLimit = value; }
        }

        private float creditLimit;

        public float CreditLimit
        {
            get { return creditLimit; }
            set { creditLimit = value; }
        }


        public MasterCard(string cardHolder) : base(cardHolder)
        {
            CardName = "MasterCard";
            int[] arr = new int[] { 51, 52, 53, 54, 55 };
            CardPrefix = arr[new Random().Next(0, arr.Length)].ToString();
            CardNumber = NumberGenerator.Instance.GenerateNumbers(16, CardPrefix);
            ExpirationDate = DateTime.Now.AddYears(5);
            SpendingLimit = 5000;
            MonthlyLimit = 30000;
            CreditLimit = 40000;
        }

        public override string RetrieveInformation()
        {
            return base.RetrieveInformation() + "\n" +
                "Expiration Date: " + ExpirationDate.ToShortDateString() + "\n" +
                "Spending Limit: " + SpendingLimit + "\n" +
                "Monthly Limit: " + MonthlyLimit + "\n" +
                "Credit Limit: " + CreditLimit + "\n";
        }
    }
}
