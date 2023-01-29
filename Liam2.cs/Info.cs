using System;
using System.Collections.Generic;
using System.Text;

namespace Liam2.cs
{
    class Info
    {
        private string firstName;
        private string lastName;
        public void setFirstName(string firstName) => this.firstName=firstName;
        public void setLastName(string lastName) => this.lastName = lastName;
      public string getLastName()
        {
            return lastName;
        }
        public string getFirstName()
        {
            return firstName;
        }
            }
}
