using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI

{
    class Program
    {
        static void Main(string[] args)
        {


            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine($"Id {cars.Id} Açıklama > {cars.Description}");
            }
        }


        
        


        
    }
}
