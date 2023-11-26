using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    public class CarRaceGame
    {
        public delegate void StartRaceHandler();

        public event StartRaceHandler RaceStartedEvent;

        public void StartRace(params Car[] cars)
        {
            Console.WriteLine("Гонка началась!");

            RaceStartedEvent?.Invoke();

            while (true)
            {
                foreach (var car in cars)
                {
                    car.Move();
                }
            }
        }

    }
    
}
