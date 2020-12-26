using System;
// интерфейс ICar включает в себя лишь те методы, что соответствуют логике
namespace ISP
{
    class Program
    {
        public interface ICar
        {
            public string Move();
            public string Stop();
            

        }
            static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

}
