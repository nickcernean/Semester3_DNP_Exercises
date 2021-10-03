using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_CarAndPredicates
{
    class RunClass
    {   
        public static void Main()
        { 
            string[] COLOURS = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
     
            List<Car> cars = new List<Car>();
            int i = 0;
            Random RandValue = new Random();
            while(i<=15)
            {

                double EgineSize = RandValue.NextDouble() + (8.5 - 1.1) + 1.1;
                double FuelEconomy = RandValue.NextDouble() + (30 - 5.5) + 5.5;
                string Colour = COLOURS[RandValue.Next(0, COLOURS.Length)];
                bool IsManualShift = true;
                if(RandValue.Next()==0)
                { IsManualShift = false; }
                cars.Add(new Car(Colour, EgineSize,FuelEconomy,IsManualShift));
                i++; 
            }

            // 1 colour
            

            foreach (Car car in cars.FindAll(car => car.Colour.Equals("Green")))
            {
                Console.WriteLine(car);
            }
            
            // 2 colour
            foreach (Car car in cars.FindAll(car => car.Colour.Equals("Blue") || car.Colour.Equals("Indigo")))
           {
               Console.WriteLine(car);
            }
            
            // array of colours 
            /* foreach (Car car in cars.FindAll(car => car.Colour.Equals(Colours)))
             {
                 Console.WriteLine(car); not sure
             }*/

            // engine size bigger than
            foreach (Car car in cars.FindAll(car => car.EngineSize > 5))
            {
                Console.WriteLine(car);
            }

            // engine size between 2 values
            foreach (Car car in cars.FindAll(car => 4 <= car.EngineSize).FindAll(car => car.EngineSize < 9))
            {
                Console.WriteLine(car);
            }
            // fueleconomy lower than
            foreach (Car car in cars.FindAll(car => car.FuelEconomy < 9))
            {
                Console.WriteLine(car);
            }
            // personal options
            foreach (Car car in cars.FindAll(car => car.IsManualShift == false))
            {
                Console.WriteLine(car);
            }
            Console.ReadLine();

        }
            
 
    }
}
