using System;
// Поведение реалезующих классов не противоречит поведению, заданному интерфейсом
namespace LSP
{
    interface IArchery
    {
        string accuracy();
    }
    interface ISecrecy
    {
        string noiselessness();
    }

    public class Hanter: ISecrecy, IArchery
    {
        public string accuracy()
        {
            string level = "высокий уровень";
            return level;
        }
        public string noiselessness()
        {
            string level = "высокий уровень";
            return level;
        }
    }
    public class Spy : ISecrecy
    {
        public string noiselessness()
        {
            string level = "очень высокий уровень";
            return level;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
