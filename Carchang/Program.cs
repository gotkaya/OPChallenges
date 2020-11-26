using System;

namespace Carchang
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string regnum;
            string color;
            int odometer;
            int fuel;
            public Car(string _mark, string _model, string _regnum,string _color, int _odometer, int _fuel)
            {
                mark = _mark;
                model = _model;
                regnum = _regnum;
                color = _color;
                odometer = 0;
                fuel = 60;
                Console.WriteLine($"The Car has been created.");


            }
            public void Mark(string newMark)
            {
                mark = newMark;
            }
            public void Model(string newmodel)
            {
                model = newmodel;
            }
            public void RegNum(string newRegNum)
            {
                mark = newRegNum;
            }

            public void Color(string newColor)
            {
                color = newColor;
            }

            public int Odometer
            {
                get { return odometer; }
            }
            
            public void ShowCarData()
            {
                Console.WriteLine($"Mark: {mark}; Model: {model}; RegNumber: {regnum};Color: {color}; Odometer;{odometer}; Fuel;{fuel}");
            }

        }

        static void Main(string[] args)
        {
            

        }
    }
}
