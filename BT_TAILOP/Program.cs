using System;

namespace Cars
{
    public interface ICar
    {
        string Color { get; }
        string Model { get; }
        void Start();
        void Stop();
    }

    public abstract class Car : ICar
    {
        public string Color { get; }
        public string Model { get; }

        protected Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public abstract void Start();

        public void Stop()
        {
            Console.WriteLine("Breaaak!");
        }

        public override string ToString()
        {
            return $"{Color} {GetType().Name} {Model}";
        }
    }

    public class Seat : Car
    {
        public Seat(string model, string color) : base(model, color)
        {
        }

        public override void Start()
        {
            Console.WriteLine("Engine start");
        }
    }

    public class Tesla : Car
    {
        public int BatteryCount { get; }

        public Tesla(string model, string color, int batteryCount) : base(model, color)
        {
            BatteryCount = batteryCount;
        }

        public override void Start()
        {
            Console.WriteLine("Engine start");
        }

        public override string ToString()
        {
            return $"{Color} {GetType().Name} {Model} with {BatteryCount} Batteries";
        }
    }

    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICar seat = new Seat("Leon", "Grey");
            ICar tesla = new Tesla("Model 3", "Red", 2);
            Console.WriteLine(seat.ToString());
            seat.Start();
            seat.Stop();
            Console.WriteLine(tesla.ToString());
            tesla.Start();
            tesla.Stop();
        }
    }
}