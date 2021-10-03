using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_CarAndPredicates
{
    class Car
    {
       
        public string Colour { get; set; }
        public double EngineSize { get; set; }
        public double FuelEconomy { get; set; }
        public bool IsManualShift { get; set; }
        public Car(string Colour, double EngineSize,double FuelEconomy,bool IsManualShift) {
            this.Colour = Colour;
            this.EngineSize = EngineSize;
            this.FuelEconomy = FuelEconomy;
            this.IsManualShift = IsManualShift; 
        }
        // Return a list with of one specified colour
        public List<Car> SpecificColouredCars(List<Car> cars, string Colour)
        { 
           return cars.FindAll(car => car.Colour.Equals(Colour));
        }
                // Return a list with of two specified colour

        public List<Car> TwoColourSpecificCars(List<Car> cars, string Colour1, string Colour2)
        {
            return cars.FindAll(car => car.Colour.Equals(Colour1) || car.Colour.Equals(Colour2));
        }
                // Return a list with of an array of  colours

        public List<Car> ArrayOfColourSpecificCars(List<Car> cars, string[] Colours)
        {
            return cars.FindAll(car => car.Colour.Equals(Colours) );//not sure about this
        }
        // Return a list with of a specified engine size volume
        public List<Car> SpecificEngineSize(List<Car> cars, double ArgEngineSize)
        {
            return cars.FindAll(car => car.EngineSize > ArgEngineSize);
        }
        // Return a list  of a specified engine volume boundaries
        public List<Car> SpecificBoundaryEngineSize(List<Car> cars, double LowerValue,double Highervalue)
        {
            return cars.FindAll(car => LowerValue<= car.EngineSize).FindAll(car=>car.EngineSize<Highervalue);
        }
        // Return a list  of a specific fuel conomy value
        public List<Car> LowerFuelEconomy(List<Car> cars, double Highervalue)
        {
            return cars.FindAll(car => car.FuelEconomy < Highervalue);
        }
        // Return a list of specific options
        public List<Car> LowerFuelEconomy(List<Car> cars, string Colour, double EngineSize,double FuelEconomy,bool Automatic)
        {
            return cars.FindAll(car => car.Colour.Equals(Colour)).FindAll(car => car.EngineSize>EngineSize).FindAll(car => car.FuelEconomy>FuelEconomy).FindAll(car => car.IsManualShift==false);
        }

        public override string ToString()
        {
         return $"Color: {Colour}, EngineSize: {EngineSize}, FuelEconomy: {FuelEconomy}, IsManualShift: {IsManualShift}";
        }
    }
}
