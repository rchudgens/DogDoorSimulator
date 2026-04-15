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

        public void Recognize(Bark bark)
        {

            Console.WriteLine($"BarkRecognizer: Heard a {bark}");
            if(_door.GetAllowedBark().Equals(bark))
                _door.Open();
            else
                Console.WriteLine("BarkRecognizer: This dog is not allowed.");
        }
    }
}
