using System;

namespace Catchal
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hungry;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungry = 0;
                Console.WriteLine($"The cat {name}has been created.");
            }
            public double Hungry
            {
                get { return hungry; }
            }
            public void Sleep()
            {
                Console.WriteLine("*Sleep*");
                hungry += 0.2;
                
            }
            public void Meow()
            {
                Console.WriteLine("Meow");
            }
           
            public void Rename(string newName)
            {
                name = newName;
            }
            public void ShowCatData()
            {
                Console.WriteLine($"Name: {name}; Color: {color}; Hungry: {hungry};");
            }
        }
        static void Main(string[] args)
        {
            Cat newCat = new Cat("Elvis", "White");

            Console.WriteLine($"The level of Hungry:{newCat.Hungry}");

            while (newCat.Hungry !=1 )
            {
                newCat.Sleep();
            }

            newCat.Meow();

            Console.WriteLine("What the Cat name:");
            string newCatName = Console.ReadLine();
            newCat.Rename(newCatName);
            newCat.ShowCatData();

        }
    }
}
