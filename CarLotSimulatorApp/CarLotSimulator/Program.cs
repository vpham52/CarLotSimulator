using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Bonus
            //Instanciate the a Carlot at the beginning of the program and as
            //you create a car add the car to the list.

            var victoriasCarLot = new CarLot();


            //Create a seperate class file called Car -- DONE

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable -- DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            //.notation 
            var honda = new Car();
            honda.Year = 2005;
            honda.Make = "Honda";
            honda.Model = "Civic";
            honda.EngineNoise = "humm";
            honda.HonkNoise = "boop";
            honda.IsDriveable = false;

            victoriasCarLot.ParkingList.Add(honda);
          

            ////object initializer syntax 
            var acura = new Car()
            {
                Year = 2005,
                Make = "Acura",
                Model = "TSX",
                EngineNoise = "revv",
                HonkNoise = "beep",
                IsDriveable = true,

            };
           



            victoriasCarLot.ParkingList.Add(acura);

            var lexus = new Car()
            {
                Year = 2015,
                Make = "Lexus",
                Model = "IS250",
                EngineNoise = "vroom",
                HonkNoise = "honk",
                IsDriveable = true,

            };

            victoriasCarLot.ParkingList.Add(lexus);

            //Custom Constructer
            var toyota = new Car()
            {
                Year = 2010,
                Make = "Toyota",
                Model = "RAV4",
                EngineNoise = "buzz",
                HonkNoise = "roar",
                IsDriveable = true
            };

            victoriasCarLot.ParkingList.Add(toyota);
            


            //Adding more cars for static exercise
            var bmw = new Car (2016, "BMW", "X5", "PURRR Vibrateeee~", "HONK BLARRRR", true);
            
            victoriasCarLot.ParkingList.Add(bmw);
          

            var astonMartin = new Car(1964, "Aston Martin", "DB5", "hummm", "Deep Honk", true);
            victoriasCarLot.ParkingList.Add(astonMartin);
        

            var vw = new Car ( 1971, "VW", "Beetle", "crank pop", "toot toot", false );
            victoriasCarLot.ParkingList.Add(vw);
            


            //Call each of the methods for each car



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            //DONE


            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console



            foreach (var car in victoriasCarLot.ParkingList)
            {
                Console.WriteLine($"Year:{car.Year}");
                Console.WriteLine($"Make:{car.Make}");
                Console.WriteLine($"Model:{car.Model}");

                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);

             

            }




        }


    }
}
