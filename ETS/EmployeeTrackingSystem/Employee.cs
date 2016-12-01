using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem
{
    class Employee: IDCard
    {
        private string mName;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        private string mEmpId;

        public string EmpId
        {
            get { return mEmpId; }
            set { mEmpId = value; }
        }

        public bool Validate()
        {
            return true;
        }

        public int Calculate(int Hours, IDCard idcard)
        {
            int signIn = idcard.SignIn;
            int signOut = idcard.Signout;
            int WorkingHours = signOut - signIn;
            return WorkingHours;
        }
    }
}
