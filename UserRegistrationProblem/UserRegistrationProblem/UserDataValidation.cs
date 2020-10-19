// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDataValidation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace UserRegistrationProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    public class UserDataValidation
    {
        /// <summary>
        /// Regular Expression for matching parameters
        /// </summary>
        public static string FIRSTNAME_REGX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LASTNAME_REGX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EMAIL_REGX = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
        public static string MOBILENUMBER_REGX = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORD_UC8 = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";

        /// <summary>
        /// Determines whether [is valid first name] [the specified first name].
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns>
        ///   <c>true</c> if [if the patter matches] [the specified first name]; otherwise, <c>false</c>.
        /// </returns>
        public string isValidEmailID(string emailId)
        {
            try
            {
                //If the passed test value does not matches the regular expression pattern then throw a custom exception
                if (Regex.IsMatch(emailId, EMAIL_REGX))
                    return "Correct Entry";
                else
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_EMAIL, "Invalid Entry");

            }
            catch (UserRegistrationCustomException exception)
            {
                //Catch the custom exception
                return exception.Message;
            }
        }

        /// <summary>
        /// Determines whether [is valid first name] [the specified first name].
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns>
        ///   <c>true</c> if [is valid first name] [the specified first name]; otherwise, <c>false</c>.
        /// </returns>
        public string isValidName(string Name)
        {
            try
            {
                //If the passed test value does not matches the regular expression pattern then throw a custom exception
                if (Regex.IsMatch(Name, FIRSTNAME_REGX))
                    return "Correct Entry";
                else
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_FIRSTNAME, "Invalid Entry");

            }
            catch (UserRegistrationCustomException exception)
            {
                //Catch the custom exception
                return exception.Message;
            }
        }

        /// <summary>
        /// Determines whether [is valid mobile number] [the specified mobile number].
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <returns>
        ///   <c>true</c> if [is valid mobile number] [the specified mobile number]; otherwise, <c>false</c>.
        /// </returns>
        public string isValidMobileNumber(string mobileNumber)
        {
            try
            {
                //If the passed test value does not matches the regular expression pattern then throw a custom exception
                if (Regex.IsMatch(mobileNumber, MOBILENUMBER_REGX))
                    return "Correct Entry";
                else
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_MOBILENUMBER, "Invalid Entry");

            }
            catch (UserRegistrationCustomException exception)
            {
                //Catch the custom exception
                return exception.Message;
            }

        }

        /// <summary>
        /// Determines whether [is valid password u c8] [the specified password].
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns>
        ///   <c>true</c> if [is valid password u c8] [the specified password]; otherwise, <c>false</c>.
        /// </returns>
        public string isValidPasswordUC8(string password)
        {
            try
            {
                //If the passed test value does not matches the regular expression pattern then throw a custom exception
                if (Regex.IsMatch(password, PASSWORD_UC8))
                    return "Correct Entry";
                else
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.WRONG_PASSWORD, "Invalid Entry");

            }
            catch (UserRegistrationCustomException exception)
            {
                //Catch the custom exception
                return exception.Message;
            }
        }
    }
}
