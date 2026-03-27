using DogDoorSimulator.Models;

namespace DogDoorSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            
            Console.WriteLine("Fido barks to go outside...");
            Console.WriteLine("Fido's owner presses the remote control button...");
            remote.PressButton();
            Console.WriteLine("Fido has gone outside...");
            Console.WriteLine("Now Fido is done and barks to come back inside...");
            Console.WriteLine("Fido's owner presses the remote control button...");
            remote.PressButton();
            Console.WriteLine("Fido is back inside...");

            Console.ReadLine();
        }
    }
}
