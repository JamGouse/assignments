using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem
{
    class IDCard
    {
        private string mId;

        public string Id
        {
            get { return mId; }
            set { mId = value; }
        }

        private int mSignIn;

        public int SignIn
        {
            get { return mSignIn; }
            set { mSignIn = value; }
        }

        private int mSignout;

        public int Signout
        {
            get { return mSignout; }
            set { mSignout = value; }
        }

    }
}
