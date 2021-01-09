/* Developer - Sean Rhone
 * Date Created - 01/26/2008
 * 
 * General Description - Simple Employee class used for Business Object examples
 **/

using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDataBindingCSharp
{
    class Employee
    {
        #region  Modular Variables 
            string _FirstName;
            string _LastName;
            string _MiddleInitial ;

            // Employee Address Fields
            string _Address1;
            string _Address2; 
            string _City; 
            string _State;
            string _ZipCode;

            Guid _Manager;
        #endregion

        #region Constructors

            public Employee(){

            }

        #endregion

        #region Public Properties
            
            /// <summary>
            /// Property to hold the first name of the employee
            /// </summary>
            public string FirstName
            {
                get { return _FirstName; }
                set { 
                        _FirstName = value;
                        Console.WriteLine("Property {0} has been changed.", "FirstName");
                    }
            }

            /// <summary>
            /// Property to hold the last name of the employee
            /// </summary>
            public string LastName
            {
                get { return _LastName; }
                set { 
                        _LastName = value;
                        Console.WriteLine("Property {0} has been changed.", "LastName");
                    }
            }

            /// <summary>
            /// Property to hold the middle initial of the employee
            /// </summary>
            public string MiddleInitial
            {
                get { return _MiddleInitial; }
                set { 
                        _MiddleInitial = value;
                        Console.WriteLine("Property {0} has been changed.", "MiddleInitial");
                    }
            }

            /// <summary>
            /// Property to hold the employees address
            /// </summary>
            public string Address1
            {
                get { return _Address1; }
                set { 
                        _Address1 = value;
                        Console.WriteLine("Property {0} has been changed.", "Address1");
                    }
            }

            /// <summary>
            /// Property to hold the employees address
            /// </summary>
            public string Address2
            {
                get { return _Address2; }
                set {
                        _Address2 = value;
                        Console.WriteLine("Property {0} has been changed.", "Address2");
                    }
            }

            /// <summary>
            /// Property to hold the employees city
            /// </summary>
            public string City
            {
                get { return _City; }
                set { 
                        _City = value;
                        Console.WriteLine("Property {0} has been changed.", "_City");
                    }
            }

            /// <summary>
            /// Property to hold the employees state
            /// </summary>
            public string State
            {
                get { return _State; }
                set { 
                        _State = value;
                        Console.WriteLine("Property {0} has been changed.", "State");
                    }
            }

            /// <summary>
            /// Property to hold the employees zip code
            /// </summary>
            public string ZipCode
            {
                get { return _ZipCode; }
                set { 
                        _ZipCode = value;
                        Console.WriteLine("Property {0} has been changed.", "ZipCode");
                    }
            }

            /// <summary>
            /// Holds employees managers ID
            /// </summary>
            public Guid Manager
            {
                get { return _Manager; }
                set { 
                        _Manager = value;
                        Console.WriteLine("Property {0} has been changed.", "Manager");
                    }
            }
	
        #endregion

    }
}
