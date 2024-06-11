using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            // version one
            Car car1 = new Car(2000, "Cadillac", "XT4", "rum rum rum", "Beep", false);

            lot.Cars.Add(car1);

            // version two 
            Car car2 = new Car();

            car2.Year = 2018;
            car2.Make = "Kia Niro";
            car2.Model = "sx";
            car2.EngineNoise = "chug chug chug";
            car2.HonkNoise = "Im the worst brand of car";
            car2.IsDriveable = false;

            lot.Cars.Add(car2);


            Car car3 = new Car()
            {
                Year = 2055,
                Make = "Audi",
                Model = "A6",
                EngineNoise = "Blub blub blub",
                HonkNoise = "meep meep",
                IsDriveable = true
            };

            lot.Cars.Add(car3);

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Console.WriteLine("Car 1 noises----------------");
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            Console.WriteLine("");
            Console.WriteLine("Car 2 noises--------------");
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            Console.WriteLine("");
            Console.WriteLine("Car 3 noises----------------");
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();

            Console.WriteLine("");


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars) 
            {
                Console.WriteLine("");
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
            }
        }
    }
}
