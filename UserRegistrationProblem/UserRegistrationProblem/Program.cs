using System;

namespace UserRegistrationProblem
{
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
        static void Main(string[] args)
        {
            UserDataValidation dataValidation = new UserDataValidation();
            Console.WriteLine("================================================");
            Console.WriteLine("Welcome to User Registration Validation Program");
            Console.WriteLine("================================================");
            Console.WriteLine("Enter User First Name=");
            firstName = Console.ReadLine();

            var validationKey = "";
            validationKey = dataValidation.isValidName(firstName);
            Console.WriteLine(validationKey);

            Console.WriteLine("Enter User Last Name=");
            lastName = Console.ReadLine();

            validationKey = dataValidation.isValidName(lastName);
            Console.WriteLine(validationKey);

            Console.WriteLine("Enter User Email Id=");
            emailId = Console.ReadLine();

            validationKey = dataValidation.isValidEmailID(emailId);
            Console.WriteLine(validationKey);


            Console.WriteLine("Enter User Mobile Number=");
            mobileNumber = Console.ReadLine();

            validationKey = dataValidation.isValidMobileNumber(mobileNumber);
            Console.WriteLine(validationKey);

            Console.WriteLine("Enter User Password=");
            password = Console.ReadLine();

            validationKey = dataValidation.isValidPasswordUC8(password);
            Console.WriteLine(validationKey);
        }
    }
}