using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    public abstract class Car
    {
        public string Model { get; }
        public int Speed { get; private set; }
        public int Position { get; private set; }

        public event EventHandler<string> FinishEvent;

        protected Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
            Position = 0;
        }

        public void StartRace()
        {
            Console.WriteLine($"{Model} начал гонку!");
        }

        public void Move()
        {
            Position += Speed;
            Console.WriteLine($"{Model} проехал {Speed} единиц расстояния. Текущая позиция: {Position}");

            if (Position >= 100)
            {
                OnFinish();
            }
        }

        protected virtual void OnFinish()
        {
            FinishEvent?.Invoke(this, $"{Model} финишировал!");

            Console.WriteLine($"{Model} финишировал!");
            Environment.Exit(0);
        }
    }
}
