using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    public class SportsCar : Car
    {
        public SportsCar(string model) : base(model, new Random().Next(5, 15))
        {
        }
    }
    public class PassengerCar : Car
    {
        public PassengerCar(string model) : base(model, new Random().Next(3, 10))
        {
        }
    }
    public class Truck : Car
    {
        public Truck(string model) : base(model, new Random().Next(2, 8))
        {
        }
    }
    public class Bus : Car
    {
        public Bus(string model) : base(model, new Random().Next(1, 6))
        {
        }
    }
    public class Program
    {
        public static void Main()
        {
            CarRaceGame game = new CarRaceGame();

            SportsCar sportsCar = new SportsCar("Спортивный автомобиль");
            PassengerCar passengerCar = new PassengerCar("Легковой автомобиль");
            Truck truck = new Truck("Грузовой автомобиль");
            Bus bus = new Bus("Автобус");

            sportsCar.FinishEvent += HandleFinishEvent;
            passengerCar.FinishEvent += HandleFinishEvent;
            truck.FinishEvent += HandleFinishEvent;
            bus.FinishEvent += HandleFinishEvent;

            game.RaceStartedEvent += sportsCar.StartRace;
            game.RaceStartedEvent += passengerCar.StartRace;
            game.RaceStartedEvent += truck.StartRace;
            game.RaceStartedEvent += bus.StartRace;

            game.StartRace(sportsCar, passengerCar, truck, bus);
        }

        private static void HandleFinishEvent(object sender, string message)
        {
            Console.WriteLine(message);
            Environment.Exit(0);
        }
    }
}
