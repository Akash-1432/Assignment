﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class cars
    {
        int carno;
        string carName;
        string carType;
        readonly double carcost = 78000000;

        public cars(int carno, string carName, string carType)
        {
            this.carno = carno;
            this.carName = carName;
            this.carType = carType;
            Console.WriteLine($" carno is : {carno}, car namee is {carName}, car Type is {carType}, car cost is {carcost}");
        }

        public cars(double cost)
        {
            carcost = cost;
            Console.WriteLine("After changing");
            Console.WriteLine($" Car number is : {carno}, Car name is {carName}, car manufacture is {carType}, Car total cost is {carcost}");
        }
        public void displaycardetails()
        {
            Console.WriteLine("Before changing");
            Console.WriteLine($" Car number is : {carno}, Car name is {carName}, car manufacture is {carType}, car total cost is {carcost}");

        }
    }
}
