using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    class AnotherHouse
    {
        public AnotherHouse()
        {

        }

        public AnotherHouse(float area)
        {

        }

        private float mArea;
        public float Area
        {
            get { return mArea; }
            set { mArea = value; }
        }

        private string mDoor;
        public string Door
        {
            get { return mDoor; }
            set { mDoor = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("My area is :{0}", mArea);
            Console.WriteLine("Door color is :{0}", mDoor);
        }
    }
}
