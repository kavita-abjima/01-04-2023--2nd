//Copy constructor
using System;
using System.Drawing;
using System.Xml.Linq;

namespace copyConstructor
{

    class Vehicle {
        private string name;
        private string color;
        private int quantity;

        public Vehicle(string Name,string Color,int Quantity){
            name = Name;
            color = Color;
            quantity = Quantity;
        }
        //copy constructor
        public Vehicle(Vehicle ob3)
        {
            name = ob3.name;
            color = ob3.color;
            quantity = ob3.quantity;

        }
        public string DetailsofVehicle
        {
            get
            {
                return "Type: " + name.ToString() +
                       "\nColor: " + color.ToString() +
                       "\nQuantity: " + quantity.ToString();
            }
        }

        public static void Main(string[] args)
        {
            Vehicle ob = new Vehicle("Bike", "Black", 40);
            Vehicle ob1 = new Vehicle(ob);
            Console.WriteLine(ob1.DetailsofVehicle);

        }
    }


}