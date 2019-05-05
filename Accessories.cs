using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneServiceApp
{
    class Accessories
    {
        protected String accessName;
        protected double price;

        public Accessories(String accessName, double price)
        {
            this.accessName = accessName;
            this.price = price;
        }
        public void setAccessName(String accessName)
        {
            this.accessName = accessName;
        }

        public String getAccessName()
        {
            return accessName;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }

        public double getPrice()
        {
            return price;
        }


        public override string ToString()
        {
            return "Accessory Name: " + accessName + " Accessory Price: $" + price;
        }
    }
}

