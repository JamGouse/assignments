using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPO
{
    class Product
    {
        public Product()
        {

        }

        private int mId;
        public int Id { get { return mId; } set { mId = value; } }

        private string mProductName;
        public string ProductName { get { return mProductName; } set { mProductName = value; } }

        private string mDescription;
        public string Description { get { return mDescription; } set { mDescription = value; } }

        private float mCurrentPrice;
        public float CurrentPrice { get { return mCurrentPrice; } set { mCurrentPrice = value; } }

        public bool Validate()
        {
            return true;
        }

        public Product Retrieve(Product prd)
        {
            int pid = 102;
            prd.Id = pid;
            prd.ProductName = ProductName;
            prd.Description = Description;
            prd.CurrentPrice = CurrentPrice;
            return prd;
        }

        public bool Save()
        {
            return true;
        }
    }
}
