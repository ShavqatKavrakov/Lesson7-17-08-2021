using System;

namespace Lesson7_17_08_2021
{
    class Program
    {
        class Animal
        {
            public string name;
            public int age;
            public Animal(string name,int age)
            {
                this.name=name;
                this.age=age;
            }
            public void GetInfo()
            {
                if(this.name=="Fox")
                {
                    Console.ForegroundColor=ConsoleColor.Yellow;
                }
                Console.WriteLine($"Имя: {name} Возраст: {age}");
             Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
           var animal=new Animal(name:"Bear",age:23);
           animal.GetInfo();
           animal=new Animal(name:"Fox",age:12);
           animal.GetInfo();
        }
    }
}
