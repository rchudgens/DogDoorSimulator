using DogDoorSimulator.Models;

namespace DogDoorSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Remote remote = new Remote(door);
            
            //Simulate the hardware hearing a bark
            Console.WriteLine("Fido starts barking...");
            recognizer.Recognize("Woof");
            Console.WriteLine("\nFido has gone outside...");
            Console.WriteLine("\nFido's all done...");

            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n...but he's stuck outside!");

            //Simulate the hardware hearing a bark again
            Console.WriteLine("\nFido starts barking...");
            recognizer.Recognize("Woof");
            Console.WriteLine("Fido is back inside...");

            Console.ReadLine();
        }
    }
}
