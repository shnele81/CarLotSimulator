using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ParkingLot {get; set;} =  new List<Car>();

    public void CheckCars()
    {
        foreach (var car in ParkingLot)
        {
            Console.WriteLine($"Make: {car.Make},  Model: {car.Model}, Year: {car.Year}");
        }
    }
}
