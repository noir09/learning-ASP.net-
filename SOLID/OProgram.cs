using System;
// модифицируем класс person через наследование
namespace OCP
{
    public class person
    {
        string name;
        int age;
    }
    public class employee: person
    {
        int experience;
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
