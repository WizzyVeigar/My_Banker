using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    abstract class BaseCard
    {
        private string cardHolder;

        public string CardHolder
        {
            get { return cardHolder; }
            set { cardHolder = value; }
        }
        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }



        string cardname;
        public string CardName
        {
            get { return cardname; }
            set { cardname = value; }
        }

        private string cardprefix;
        public string CardPrefix
        {
            get { return cardprefix; }
            set { cardprefix = value; }
        }


        private string cardnumber;
        public string CardNumber
        {
            get { return cardnumber; }
            set { cardnumber = value; }
        }

        public BaseCard()
        {

        }
        public BaseCard(string cardHolder)
        {
            CardHolder = cardHolder;
        }

        /// <summary>
        /// Virtual method for Retrieving all information regarding the card
        /// </summary>
        /// <returns>Returns a string with all information around this card</returns>
        public virtual string RetrieveInformation()
        {
            return "CardHolder: " + CardHolder + "\n" +
                "Account Number: " + AccountNumber + "\n" +
                "Card Name: " + CardName + "\n" +
                "Card Number: " + CardNumber;
        }
    }
}
