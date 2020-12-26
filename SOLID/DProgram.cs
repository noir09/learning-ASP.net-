using System;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
//используем интерфейс IEngine, чтобы снизить зависимость
namespace ID 
{
    public interface IEngine
    {
        double GetSize();
    }
    public class Engine : IEngine
    {
        public double GetSize()
        {
            return 2.5; // in liters
        }
    }

    public class Car
    {
        private readonly IEngine _engine;
        public Car(IEngine engine)
        {
            _engine = engine;
        }
        
        public void GetDescription()
        {
            Console.WriteLine("Engine size: {0}L", _engine.GetSize());
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
         
           IEngine engine = new Engine();
            Car car = new Car(engine);

            car.GetDescription();

        }
    }
}
