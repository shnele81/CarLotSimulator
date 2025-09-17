using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            
            var firstCar = new Car();
            firstCar.Make = "Ford";
            firstCar.Model = "Escape";
            firstCar.Year = 2015;
            firstCar.IsDriveable = true;

            firstCar.MakeEngineNoise("peaceful and quiet");
            
            firstCar.MakeHonkNoise("A fire alarm went off");
        }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    }
}
