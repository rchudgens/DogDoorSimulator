using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoorSimulator.Models
{
    public class Bark
    {
        public string Sound { get; private set; }
        public Bark(string sound)
        {
            Sound = sound;
        }

        public bool Equals(Bark bark)
        {
            if (bark == null)
                return false;
            if(bark.Sound == Sound)
                return true;
            else
                return false;

        }
    }
}
