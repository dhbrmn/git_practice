// Archmage.cs
using System;

namespace MagicalInheritance
{
    public class Archmage : Mage
    {
        public Archmage( string title ) : base(title)
        {
            Title = title;
        }

        public override Storm CastRainStorm()
        {
            Storm rainStorm = new Storm("rain", true, Title);
            return rainStorm;
        }

        public Storm CastLightningStorm()
        {
            Storm lightningStorm = new Storm("lightning", true, Title);
            return lightningStorm;
        }
    }
}

