using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();
            
            var firstCar = new Car();
            firstCar.Make = "Ford";
            firstCar.Model = "Escape";
            firstCar.Year = 2015;
            firstCar.IsDriveable = true;

            firstCar.MakeEngineNoise("peaceful and quiet");
            
            firstCar.MakeHonkNoise("A fire alarm went off");
            
            carLotOne.ParkingLot.Add(firstCar);
            
            var secondCar = new Car();
            secondCar.Make = "Mazda";
            secondCar.Model = "Civic";
            secondCar.Year = 2016;
            secondCar.IsDriveable = true;
            
            secondCar.MakeEngineNoise("peaceful and quiet");
            secondCar.MakeEngineNoise("A Humming Bird");
            
            carLotOne.ParkingLot.Add(secondCar);
            
            var thirdCar = new Car();
            thirdCar.Make = "Toyota";
            thirdCar.Model = "Camry";
            thirdCar.Year = 1995;
            thirdCar.IsDriveable = true;
            
            thirdCar.MakeEngineNoise("loud and clunky");
            thirdCar.MakeEngineNoise("A trombone");
            
            carLotOne.ParkingLot.Add(thirdCar);

            carLotOne.CheckCars();
            
            Console.WriteLine($"The number of cars in the lot is {CarLot.numberOfCars}");
        }
            
    }
    
}
