using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House
{
    class Door
    {
        public Door()
        {
           
        }

        public Door(string color)
        {
            
        }

        private string mColor;
        public string Color 
        { 
            get{return mColor;}
            set {mColor=value ;}
        }

        public void ShowData()
        {
            Console.WriteLine("Door color is :{0}", mColor);
        }
        
    }
}
