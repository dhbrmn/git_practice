// Mage.cs
using System;

namespace MagicalInheritance
{
    public class Mage : Pupil
    {

        public Mage( string title ) : base(title)
        {
            Title = title;
        }

        public virtual Storm CastRainStorm()
        {
            Storm rainStorm = new Storm("rain", false, Title);
            return rainStorm;
        }
    }
}

