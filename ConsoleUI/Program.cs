using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetALL())
            {
                Console.WriteLine(car.Id);
            }

        }
    }
}
