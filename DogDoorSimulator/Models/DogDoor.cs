using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoorSimulator.Models
{
    internal class DogDoor
    {
        public bool IsOpen { get; set; }

        public DogDoor()
        {
            IsOpen = false;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            IsOpen = true;
            Thread.Sleep(5000); // Simulate the dog going through the door
            Close();
        }
        public void Close()
        {
            Console.WriteLine("The dog door closes.");
            IsOpen = false;
        }
    }
}
