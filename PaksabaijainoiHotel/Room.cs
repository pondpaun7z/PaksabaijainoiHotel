using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaksabaijainoiHotel
{
    class Room
    {
        private int person;
        private int price;


        public Room(int person, int price)
        {
            this.person = person;
            this.price = price;
        }

        public int getPerson()
        {
            return person;
        }

        public int getPrice()
        {
            return price;
        }

    }
}
