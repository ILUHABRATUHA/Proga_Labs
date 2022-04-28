using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class ZHES
    {
        private ZHES() { }
        private int number;
        private string district;
        private int citizensAmount;
        private int numberOfPaid;
        private Tariff tariff = new();
        static ZHES instance;

        public int Number
        {
            get {return number;}
            set {number = value;}
        }

        public string District
        {
            get { return district; }
            set { district = value; }
        }

        public int NumberOFPaid
        {
            get { return numberOfPaid; }
            set { numberOfPaid = value; }
        }

        public int CitizensAmount
        {
            get { return citizensAmount; }
            set { citizensAmount = value; }
        }

        public Tariff Tariff
        {
            get { return tariff; }
            set { tariff = value; }
        }

        public static ZHES getInstance()
        {
            if(instance == null)
            {
                instance = new ZHES();
            }

            return instance;
        }

        public int calculateDebt()
        {
            if(citizensAmount < numberOfPaid) {
                return 0;
            }
            else
            {
                return (citizensAmount - numberOfPaid) * tariff.Price;
            }
            
        }
    }
}
