using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism is cool
            //added appropriate datatype to interfaces (was just strings before)
            List<BaseCard> listOfCards = new List<BaseCard>();
            listOfCards.Add(new VISAElectron("René"));
            listOfCards.Add(new Visa("Peter"));
            listOfCards.Add(new Maestro("Dennis"));
            listOfCards.Add(new MasterCard("Kenneth"));
            listOfCards.Add(new Haevekort("Emil"));

            foreach (BaseCard card in listOfCards)
            {
                Console.WriteLine(card.RetrieveInformation());
            }
            Console.ReadKey();
        }
    }
}
