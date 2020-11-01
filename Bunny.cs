using System;

interface Animal
{
    public void sound();
}
namespace IoDemo
{
    
    class Bunny:Animal
    {

        public void sound()
        {
            Console.WriteLine("Inside Bunny's Sound method");
        }


        static void Main(string[] args)
        {
            Animal animal = new Bunny();
            animal.sound();
        }


    }

    
}
