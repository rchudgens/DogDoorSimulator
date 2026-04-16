using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoorSimulator.Models
{
    internal class DogDoor
    {
        public bool IsOpen { get; set; }
        public List<Bark> AllowedBarks { get; set; }

        public DogDoor()
        {
            SetAllowedBarks();
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

        public void SetAllowedBarks()
        {
            AllowedBarks = new List<Bark> { new Bark("Woof!"), new Bark("Bow-wow!"), new Bark("Ruff!") };
        }

        public List<Bark> GetAllowedBarks()
        {
            return AllowedBarks;
        }

        public void AddAllowedBark(Bark bark) 
        {
            AllowedBarks.Add(bark);
        }
    }
}
