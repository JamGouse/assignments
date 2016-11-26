using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    class HouseClass
    {

        public HouseClass ()
	    {

	    }
        private float mArea;
        public float Area 
        { 
            get{return mArea;}
            set{mArea=value; }
        }

        public void ShowData()
        {
            Console.WriteLine("My area is :{0}", mArea);
        }
    }
}
