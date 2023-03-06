// Mage.cs
using System;

namespace MagicalInheritance
{
    public class Mage : Pupil
    {

        public Mage( string title, string origin ) : base(title, origin)
        {
            Title = title;
            Origin = origin;
        }

        public virtual Storm CastRainStorm()
        {
            Storm rainStorm = new Storm("rain", false, Title, Origin);
            return rainStorm;
        }
    }
}

