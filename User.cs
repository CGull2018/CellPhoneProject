using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneServiceApp
{
    class User
    {
        protected String firstName;
        protected String lastName;
        protected String userName;
        protected String password;

        public Phone phone;
        public Plan plan;
        public Accessories accessories;


        public User (String firstName, String lastName, String userName, String password, Phone phone, Plan plan, Accessories accessories)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.password = password;
            this.phone = phone;
            this.plan = plan;
            this.accessories = accessories;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getFirstName()
        {
            return firstName;
        }
        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public String getLastName()
        {
            return lastName;
        }
        public void setUserName(String userName)
        {
            this.userName = userName;
        }

        public String getUserName()
        {
            return userName;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }

        public String getPassword()
        {
            return password;
        }


        public override string ToString()
        {
            return "First Name: " + firstName + "Last Name: " + lastName + "\n UserName: " + userName +
                "\nPhone: " + phone.ToString() +
                "\nPhone Plan: " + plan.ToString() +
                "\nAccessories: " + accessories.ToString();
        }




    }
}
