using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorSimulator.Models
{
    internal class Remote
    {
        private DogDoor _door;

        public Remote(DogDoor door)
        {
            _door = door;
        }

        public async Task PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (_door.IsOpen)
            {
                _door.Close();
            }
            else
            {
                _door.Open();
            }
        }
    }
}
