using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneServiceApp
{
    class Plan
    {
        protected String planName;
        protected int minutes;
        protected double price;

        public Plan(String planName, int minutes, double price)
        {
            this.planName = planName;
            this.minutes = minutes;
            this.price = price;
        }
        public void setPlanName(String planName)
        {
            this.planName = planName;
        }

        public String getPlanName()
        {
            return planName;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }

        public double getPrice()
        {
            return price;
        }
        public void setMinutes(int minutes)
        {
            this.minutes = minutes;
        }

        public double getMinutes()
        {
            return minutes;
        }


        public override string ToString()
        {
            return "Plan Name: " + planName + " Minutes Avaliable: " + minutes + " Plan Price: $" + price ;
        }
    }
}
