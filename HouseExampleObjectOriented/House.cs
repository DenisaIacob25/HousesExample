using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExampleObjectOriented
{
    class House
    {
        private string color; //declaring fields in a class either public or private
        private int rooms;
        private int size;
        private int doors;

        private string name;

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //constructors
        public House()
        {
            this.color = "Grey";
            this.rooms = 2;
            this.size = 300;
            this.doors = 1;
        }

        public House(string color, int size)
        {
            this.color = color;
            this.size = size;
        }

        public House(string color, int rooms, int size, int doors)
        {
            this.color = color;
            this.rooms = rooms;
            this.size = size;
            this.doors = doors;
        }

        //methods
        public void Paint(string color) //creating  a method, public = anyone can modify it, void = won't return anything
        {
            this.color = color; //"this" will call back to the variable in the class above
        }
        public string CurrentColor()
        {
            return color;
        }
        public void DisplayHouseInfo()
        {
            Console.Write("House Color: " + color);
            Console.Write(", # of rooms: " + rooms);
            Console.Write(", size is: " + size + "sq/ft");
            Console.WriteLine(", with: " + doors + " doors.");
        }

    }
}
