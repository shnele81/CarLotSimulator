using System;

namespace CarLotSimulator;

public class Car
{
    //TODO

    //Create a seperate class file called Car
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property

    public string Make {get; set;}
    public string Model {get; set;}
    public int Year {get; set;}
    public string EngineNoise {get; set;}
    public string HonkNoise {get; set;}
    public bool IsDriveable {get; set;}

    public void MakeEngineNoise(string engineNoise)
    {
        EngineNoise = engineNoise;
        Console.WriteLine($"The {Make} {Model} made in {Year} has an engine noise that sounds like {engineNoise}.");
    }

    public void MakeHonkNoise(string honkNoise)
    {
        HonkNoise = honkNoise;
        Console.WriteLine($"The {Make} {Model} made in {Year} has an engine noise that sounds like {honkNoise}.");
    }
}