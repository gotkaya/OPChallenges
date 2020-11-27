using System;

namespace Carchang
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string regNumber;
            string color;
            int odo;
            int fuelTank;
            public Car(string _mark, string _model, string _color, string _regNumber )
            {
                mark = _mark;
                model = _model;
                color = _color;

                if (_regNumber.Length != 6)
                {
                    regNumber = "udefined";
                } else
                {
                    regNumber = _regNumber;
                }
                fuelTank = 60;
                odo = 0;
            }
            public string Model
            {
                get { return mark; }
            }
            public string Mark
            {
                get { return Model; }
            }
            public string Color
            {
                get { return color; }
            }
            public string RegNumber
            {
                get { return regNumber; }
            }
            public int FuelTank
            {
                get { return fuelTank; }
            }
            public int Odo
            {
                get { return odo; }
            }

            public void Drive()
            {
                odo += 100;
                fuelTank -= 5;
            }

            public void ShowCarDetails()
            {
                Console.WriteLine($"Model:{model}; \n Mark :{mark}; \n Color:{color}; \n RegNumber:{regNumber};\n Fuel:{fuelTank};\n Odo:{odo}; ");
            }

        }
        static void Main(string[] args)
        {
            Car newCar = new Car("toyota", "supra", "red", "4444GGG");
            while (newCar.FuelTank != 0)
            {
                newCar.Drive();
            }
            Console.WriteLine("The ride is over");
            newCar.ShowCarDetails();
        }
    }
}



