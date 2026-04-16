using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
            bool isAllowed = false;

            Console.WriteLine($"BarkRecognizer: Heard a {bark.Sound}");
            foreach (var allowedBark in _door.GetAllowedBarks())
            {
                if (allowedBark.Equals(bark))
                {
                    isAllowed = true;
                }
            }

            if (isAllowed) {
                Console.WriteLine("BarkRecognizer: This dog is allowed.");
                _door.Open();
            }
            else
                Console.WriteLine("BarkRecognizer: This dog is not allowed.");
        }
    }
}
