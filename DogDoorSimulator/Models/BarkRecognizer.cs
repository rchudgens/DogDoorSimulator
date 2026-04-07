using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoorSimulator.Models
{
    internal class BarkRecognizer
    {
        private DogDoor _door;
        public BarkRecognizer(DogDoor door) {
            _door = door;
        }

        public void Recognize(string bark)
        {
            Console.WriteLine($"BarkRecognizer: Heard a {bark}");
            // In a real implementation, you would have logic to determine if the bark is recognized
            // For this simulation, we will assume any bark is recognized
            _door.Open();
        }
    }
}
