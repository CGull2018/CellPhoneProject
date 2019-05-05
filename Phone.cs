using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneServiceApp
{
    class Phone
    {

        protected String phoneName;
        protected double price;
        protected double tax;

        public double cost;

        public Phone(String phoneName, double price, double tax)
        {
            this.phoneName = phoneName;
            this.price = price;
            this.tax = tax;
        }
        public void setPhoneName(String phoneName)
        {
            this.phoneName = phoneName;
        }

        public String getPhoneName()
        {
            return phoneName;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }

        public double getPrice()
        {
            return price;
        }
        public void setTax(double tax)
        {
            this.tax = tax;
        }

        public double getTax()
        {
            return tax;
        }

        public double getCost()
        {
            return price * (1 + tax);
        }

        public override string ToString()
        {
            return "Phone Model: " + phoneName + "\nPhone Price: $" + price + "\nTax: $" + tax;
         
        }
    }

}
