 using System;
using System.Reflection;

namespace CarLotSimulator
{
	public class Car
	{
        public Car()
        {
            //Static Exercise
            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars added: {CarLot.numberOfCars}");
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

            CarLot.numberOfCars++;
            Console.WriteLine($"The number of cars added: {CarLot.numberOfCars}");
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
               
         
        public void MakeEngineNoise(string engineNoise)
        {
            Console.WriteLine($"The car engine goes {EngineNoise}");
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine($"The car horn says {HonkNoise}\n");
        }


    }
}

