// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserData.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Praveen Kumar Upadhyay"/>
// --------------------------------------------------------------------------------------------------------------------
namespace UserRegistrationProblem
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// The main class containing user data
    /// </summary>
    public class UserData
    {
        /// <summary>
        /// Declaration of the member variable required for data of user
        /// </summary>
        public string firstName;
        public string lastName;
        public string emailId;
        public string mobileNumber;
        public string password;

        /// <summary>
        /// Declaration of a parameterised constructor to instantinate the object of the User-Data
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailId"></param>
        /// <param name="mobileNumber"></param>
        /// <param name="password"></param>
        public UserData(string firstName, string lastName, string emailId, string mobileNumber, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailId = emailId;
            this.mobileNumber = mobileNumber;
            this.password = password;
        }
    }
}

