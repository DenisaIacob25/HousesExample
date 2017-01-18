using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExampleObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House("green", 4, 1000, 3);
            House house2 = new House("blue", 700);
            House house3 = new House();

            house1.DisplayHouseInfo();
            house2.DisplayHouseInfo();
            house3.DisplayHouseInfo();

            house2.Paint("Yellow");
            house2.DisplayHouseInfo();

            house2.Name = "The blue house";
            Console.WriteLine(house2.Name); //outputting the value of the property 
            
            //house1.Paint("Green");
            //house1.NumberofRooms(4);
            //house1.SetSize(1000);
            //house1.NumberOfDoors(3);


            //Console.WriteLine(house1.CurrentColor());

            //house1.Paint("White");
            //Console.WriteLine(house1.CurrentColor());

            //House house2 = new House();
            //house2.Paint("Blue");
            //Console.WriteLine("House one is: " + house1.CurrentColor());
            //Console.WriteLine("House two is: " + house2.CurrentColor());
        }
    }
}
