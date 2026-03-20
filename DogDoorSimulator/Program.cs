using DogDoorSimulator.Models;

namespace DogDoorSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            
            remote.PressButton();
            remote.PressButton();
        }
    }
}
