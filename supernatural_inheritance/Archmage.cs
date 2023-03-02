// Archmage.cs
using System;

namespace MagicalInheritance
{
    public class Archmage : Mage
    {
        public Archmage( string title, string origin ) : base(title, origin)
        {
            Title = title;
            Origin = origin;
        }

        public override Storm CastRainStorm()
        {
            Storm rainStorm = new Storm("rain", true, Title, Origin);
            return rainStorm;
        }

        public Storm CastLightningStorm()
        {
            Storm lightningStorm = new Storm("lightning", true, Title, Origin);
            return lightningStorm;
        }
    }
}

