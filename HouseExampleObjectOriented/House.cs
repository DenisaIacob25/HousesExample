using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseExampleObjectOriented
{
    class House
    {
        private string color; //declaring fields in a class
        private int rooms;
        private int size;
        private int doors;

        public void Paint(string color) //creating  a method, public = anyone can modify it, void = won't return anything
        {
            this.color = color; //"this" will call back to the variable in the class above
        }
        public string CurrentColor()
        {
            return color;
        }

    }
}
