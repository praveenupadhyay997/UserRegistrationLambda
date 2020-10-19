// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserRegistrationCustomException.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace UserRegistrationProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class UserRegistrationCustomException : Exception
    {
        /// <summary>
        /// Enumerating the message as constant variables  in terms of throwing exception type
        /// 0-WRONG_FIRSTNAME and 1-WRONG_LASTNAME
        /// 2-WRONG_EMAIL 3-WRONG_MOBILENUMBER 4-WRONG_PASSWORD
        /// </summary>
        public enum ExceptionType
        {
            WRONG_FIRSTNAME, WRONG_LASTNAME, WRONG_EMAIL, WRONG_MOBILENUMBER, WRONG_PASSWORD
        }
        public readonly ExceptionType type;

        /// <summary>
        /// Parameterised constructor for the User registration custom exception class intended to overwrite the base class exception message
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
