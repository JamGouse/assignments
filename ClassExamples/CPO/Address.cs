using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPO
{
    class Address
    {
        public Address()
        {

        }
        private string mStreetOne;
        public string StreetOne { get { return mStreetOne; } set { mStreetOne = value; } }

        private string mStreetTwo;
        public string StreetTwo { get { return mStreetTwo; } set { mStreetTwo = value; } }

        private string mCity;
        public string City { get { return mCity; } set { mCity = value; } }

        private string mPinCode;
        public string PinCode { get { return mPinCode; } set { mPinCode = value; } }
    }
}
