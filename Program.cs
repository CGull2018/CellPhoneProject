using System;
using System.Collections;

namespace PhoneServiceApp
{
    class Program
    {
        static void Main(string[] args)
        {

            User user;
            Phone phone;
            Plan plan;
            Accessories accessories;

            // create new phone objects and add data 
            Phone phoneA = new Phone("Model 100", 29.95, .06);
            Phone phoneB = new Phone("Model 110", 49.95, .06);
            Phone phoneC = new Phone("Model 200", 99.95, .06);
            //create array list for phone items
            ArrayList phoneList = new ArrayList();

            phoneList.Add(phoneA);
            phoneList.Add(phoneB);
            phoneList.Add(phoneC);

            //Create new plan objects and add datat
            Plan planA = new Plan("Plan A ", 300, 45.00);
            Plan planB = new Plan("Plan B ", 800, 65.00);
            Plan planC = new Plan("Plan C ", 1500, 99.00);

            //Create array list for plan objects
            ArrayList planList = new ArrayList();

            planList.Add(planA);
            planList.Add(planB);
            planList.Add(planC);

            //create new accessories and add data
            Accessories access1 = new Accessories("VoiceMail ", 5.0);
            Accessories access2 = new Accessories("Text Message ", 10);

            //create array list for accessories objects
            ArrayList accessoriesList = new ArrayList();
            accessoriesList.Add(access1);
            accessoriesList.Add(access2);

            //create a new user
            User user1 = new User("Cody", "Gullickson", "CG", "CG123", phoneA, planA, access2);

            //create a new user list array
            ArrayList userList = new ArrayList();

            userList.Add(user1);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            //Variables
            String action = "";
            String choose1 = "";
            bool flag = false;
            bool flag2 = false;
            bool member = false;

            //User Variables
            String userName = "";
            String password = "";

            String firstName = "";
            String lastName = "";

            int buyPhone = 0;
            int buyPlan = 0;
            int buyAccessory = 0;


            // main interface
            do
            {
                Console.WriteLine("Mobile Service Carriers United: ");
                Console.WriteLine("Are you a current user? (Yes or No)");
                action = Console.ReadLine();

                Console.WriteLine("Action: " + action);
                if (action.Equals("Yes") || action.Equals("yes"))
                {

                    Console.WriteLine("Please enter your UserName: ");
                    userName = Console.ReadLine();
                    Console.WriteLine("Please enter your Password: ");
                    password = Console.ReadLine();
                    member = true;



                }
                else if (action.Equals("no") || action.Equals("No"))
                {
                    Console.WriteLine("Please create a new User Profile");
 

                    //enter new user first name
                    Console.WriteLine("Please enter First Name: ");
                    firstName = Console.ReadLine();

                    //enter new user Last name
                    Console.WriteLine("Please enter Last Name: ");
                    lastName = Console.ReadLine();

                    //enter new user User name
                    Console.WriteLine("Please enter User Name: ");
                    userName = Console.ReadLine();

                    //enter new user Password
                    Console.WriteLine("Please enter Password: ");
                    password = Console.ReadLine();
                    
                    userList.Add(new User(firstName, lastName, userName, password, null, null, null));

                }
            } while (flag != false);


            do
            {
                Console.WriteLine("What Option would you like to View? \n" +
                    "1) Vendor Phones: \n" +
                    "2) Vendor Plans: \n" +
                    "3) Vendor Accessories: \n" +
                    "4) User Bill: ");

                choose1 = Console.ReadLine();

                switch (choose1)
                {
                    case "1":
                        Console.WriteLine("User Choice: {0} Vendor Phones", choose1);
                       // Console.WriteLine("Phone List: \n There are " + phoneList.Capacity + " phone models avaliable to choose from.");

                        foreach (var Phone in phoneList)
                        {
                            Console.WriteLine("\n" + Phone.ToString());
                        }

                        break;
                    case "2":
                        Console.WriteLine("User Choice: {0} Vendor Plans", choose1);
                        //Console.WriteLine("Plan List: \n THere are " + planList.Capacity + " plans avaliable to choose from.");

                        foreach (var Plan in planList)
                        {
                            Console.WriteLine("\n" + Plan.ToString());
                        }

                        break;
                    case "3":
                        Console.WriteLine("User Choice: {0} Vendor Accessories", choose1);
                        //Console.WriteLine("Accessories List: \n THere are " + accessoriesList.Capacity + " accessories avaliable to choose from.");
                        foreach (var Accessory in accessoriesList)
                        {
                            Console.WriteLine("\n" + Accessory.ToString());
                        }
                        break;
                    case "4":
                        Console.WriteLine("User Choice: {0} User Bill", choose1);
                        if (member == true)
                        {
                            foreach (var User in userList)
                            {
                                Console.WriteLine("\n" + User.ToString());
                            }
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("What Phone would you like to purchase? \n" +
                                "Phone A: Option(1)\n" +
                                "Phone B: Option(2)\n" +
                                "Phone C: Option(3)\n");
                                buyPhone = (int)Console.Read();
                            } while (buyPhone <= 3 && buyPhone > 0);


                        }

                        break;

                    default:

                        break;

                }
                Console.WriteLine("Would you like to view more options? (Yes or No)");
                action = Console.ReadLine();
                if (action.Equals("Yes") || action.Equals("yes"))
                {
                    flag2 = true;

                }
                else if (action.Equals("no") || action.Equals("No"))
                {
                    flag2 = false;
                }
            } while (flag2 == true);

        }
    }
}
