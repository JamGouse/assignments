using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPO
{
    class Customer
    {
        public Customer()
        {

        }

        private int mId;
        public int Id { get { return mId; } set { mId = value; } }

        private string mLastName;
        public string LastName { get { return mLastName; } set { mLastName = value; } }

        private string mFirstName;
        public string FirstName { get { return mFirstName; } set { mFirstName = value; } }

        private string mEmailID;
        public string EmailID { get { return mEmailID; } set { mEmailID = value; } }

        private Address mHomeAddress;
        public Address HomeAddress { get { return mHomeAddress; } set { mHomeAddress = value; } }


        public bool Validate()
        {
            return true;
        }

        public Customer Retrieve(int id)
        {
            //int id = 101;
            Customer cst = new Customer();
            if (id==0)
            {
                cst.Id = id;
                cst.FirstName = FirstName;
                cst.LastName = LastName;
                cst.EmailID = EmailID;
                cst.HomeAddress = HomeAddress;
                return cst;
            }
            return null;
        }

        public bool Save()
        {
            return true;
        }
    }
}
