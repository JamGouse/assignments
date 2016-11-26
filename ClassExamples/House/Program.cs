using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseClass house = new HouseClass();
            house.Area = 1300;
            house.ShowData();
            
            Door door = new Door();
            door.Color = "Green";
            door.ShowData();

            AnotherHouse anotherhouse = new AnotherHouse();
            anotherhouse.Area = 1400;
            anotherhouse.Door = "Red";
            anotherhouse.ShowData();
            Console.ReadLine();
        }
    }
}
