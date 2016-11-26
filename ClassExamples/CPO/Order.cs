using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPO
{
    class Order
    {
        public Order()
        {

        }

        private int mId;
        public int Id { get { return mId; } set { mId = value; } }

        public List<Customer> customers;
        public List<Customer> Customer { get { return customers; } }

        private DateTime mOrderDate;
        public DateTime OrderDate { get { return mOrderDate; } set { mOrderDate = value; } }

        private Address mShipingAddress;
        public Address ShippingAddress { get { return mShipingAddress; } set { mShipingAddress = value; } }

        public bool Validate()
        {
            return true;
        }

        public Order Retrieve(Order ord)
        {
            int oid = 103;
            ord.Id = oid;
            ord.OrderDate = OrderDate;
            return ord;
        }

        public bool Save()
        {
            return true;
        }
    }
}
