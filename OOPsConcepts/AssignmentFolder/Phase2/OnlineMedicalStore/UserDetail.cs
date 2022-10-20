using System;
using System.Collections.Generic;
namespace OnlineMedicalStore
{   

    /// <summary>
    /// used to get detail from the user to validate
    /// </summary>
    public class UserDetail
    { 

        /// <summary>
        /// used to get user id
        /// </summary>
        private static int s_userId = 1000;
        public string UserId { get;  }
        /// <summary>
        /// 
        /// used to get user name
        /// </summary>
        /// <value></value>
        public string Name{ get; set; }
        /// <summary>
        /// used to get user age
        /// </summary>
        /// <value></value>
        public int Age { get; set; } 
        /// <summary>
        /// used to get user city
        /// </summary>
        /// <value></value>
        public string City { get; set; }
        /// <summary>
        /// used to get user mobile number
        /// </summary>
        /// <value></value>
        public double Mobile { get; set; }
        /// <summary>
        /// used to get user initial balance
        /// </summary>
        /// <value></value>
        public double Balance { get; set; }   


/// <summary>
/// constructors are used to initiate all the values
/// </summary>
/// <param name="name">used to initialize the user name in the parameter</param>
/// <param name="age">used to initialize the age from the user in the parameter</param>
/// <param name="city">used to initialize the city form the user in the parmeter</param>
/// <param name="mobile">used to initialize the mobile number in the parameter</param>
/// <param name="balance">used to initialize the balance from the user in the parameter</param>
        public UserDetail(string name,int age, string city,double mobile,double balance)
        {

            s_userId++;
            UserId = "UID"+s_userId;
            Name = name;
            Age = age;
            City = city;
            Mobile = mobile;
            Balance = balance;


        }

    }
}