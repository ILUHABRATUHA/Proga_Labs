using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Tariff
    {
        private int price;

        public Tariff()
        {
            this.price = 1;
        }

        public Tariff(int price)
        {
            this.price = price;
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

    }
}
