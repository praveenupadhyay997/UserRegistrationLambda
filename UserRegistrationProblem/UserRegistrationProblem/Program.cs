// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace UserRegistrationProblem
{
    using System;
    using System.Collections.Generic;
    using System.Net.NetworkInformation;
    using System.Text.RegularExpressions;
    class Program
    {
        // <summary>
        /// All the member variable as the user data to be entered locally from user's
        /// </summary>
        public static string firstName;
        public static string lastName;
        public static string emailId;
        public static string mobileNumber;
        public static string password;
        /// <summary>
        /// All Regex pattern declared as static variables
        /// </summary>
        public static string FIRSTNAME_REGX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EMAIL_REGX = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
        public static string MOBILENUMBER_REGX = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORD_UC8 = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
        /// <summary>
        ///UC-13 Checking the validation of name on basis of pattern using lambda expression
        /// </summary>
        /// <param name="list"></param>
        public static void IsValidNameLambda(List<UserData> list)
        {
            Console.WriteLine("================================================");
            Console.WriteLine("The names valid in the list are ");
            //Making Use of Lambda Expression to print the list of valid names on matching pattern 
            foreach (UserData userData in list.FindAll(name => Regex.IsMatch(name.firstName, FIRSTNAME_REGX) && Regex.IsMatch(name.lastName, FIRSTNAME_REGX)))
            {
                Console.WriteLine(userData.firstName + " "+userData.lastName);
            }
            Console.WriteLine("================================================");
        }
        /// <summary>
        ///UC-13 Checking the validation of email on basis of pattern using lambda expression
        /// </summary>
        /// <param name="list"></param>
        public static void IsValidEmailLambda(List<UserData> list)
        {
            Console.WriteLine("The email-Id valid in the list are ");
            //Making Use of Lambda Expression to print the list of valid email-Id on matching pattern 
            foreach (UserData userData in list.FindAll(name => Regex.IsMatch(name.emailId,EMAIL_REGX)))
            {
                Console.WriteLine(userData.emailId);
            }
            Console.WriteLine("================================================");
        }
        /// <summary>
        ///UC-13 Checking the validation of mobile number on basis of pattern mentioned in UC's using lambda expression
        /// </summary>
        /// <param name="list"></param>
        public static void IsValidMobileNumberLambda(List<UserData> list)
        {
            Console.WriteLine("The Mobile Number valid in the list are ");
            //Making Use of Lambda Expression to print the list of valid mobile number on matching pattern 
            foreach (UserData userData in list.FindAll(name => Regex.IsMatch(name.mobileNumber,MOBILENUMBER_REGX)))
            {
                Console.WriteLine(userData.mobileNumber);
            }
            Console.WriteLine("================================================");
        }
        /// <summary>
        ///UC-13 Checking the validation of password on basis of pattern mentioned till UC-8 using lambda expression
        /// </summary>
        /// <param name="list"></param>
        public static void IsValidPasswordLambda(List<UserData> list)
        {
            Console.WriteLine("The Password valid in the list are ");
            //Making Use of Lambda Expression to print the list of valid password on matching pattern 
            foreach (UserData userData in list.FindAll(name => Regex.IsMatch(name.password, PASSWORD_UC8)))
            {
                Console.WriteLine(userData.password);
            }
            Console.WriteLine("================================================");
        }
        static void Main(string[] args)
        {
            List<UserData> userDataList = new List<UserData>();
            Console.WriteLine("================================================");
            Console.WriteLine("Welcome to User Registration Validation Program");
            Console.WriteLine("================================================");
            char reply = 'y';
            //A hard coded entry inside the list of user data
            userDataList.Add(new UserData("Rajendra", "Sharma", "rajsharma@gmail.com", "91 9025454466", "Rajsharma1@"));
            //Need for an exit controlled loop so as to allow atleast one entry
            do
            {
                Console.WriteLine("Enter User First Name=");
                firstName = Console.ReadLine();

                Console.WriteLine("Enter User Last Name=");
                lastName = Console.ReadLine();

                Console.WriteLine("Enter User Email Id=");
                emailId = Console.ReadLine();

                Console.WriteLine("Enter User Mobile Number=");
                mobileNumber = Console.ReadLine();

                Console.WriteLine("Enter User Password=");
                password = Console.ReadLine();

                userDataList.Add(new UserData(firstName, lastName, emailId, mobileNumber, password));
                //Taking a flag to re-iterate the entry in User-Data List
                Console.WriteLine("Want To Add more data for validation at once. Press y else n");
                reply = Convert.ToChar(Console.ReadLine());
            }
            while (reply == 'y');
            //Calling valid name function to print the list of valid names
            Program.IsValidNameLambda(userDataList);
            //Calling valid email function to print the list of valid email-Id
            Program.IsValidEmailLambda(userDataList);
            //Calling valid mobile number function to print the list of valid mobile numbers
            Program.IsValidMobileNumberLambda(userDataList);
            //Calling valid password function to print the list of valid password
            Program.IsValidPasswordLambda(userDataList);
        }
    }
}