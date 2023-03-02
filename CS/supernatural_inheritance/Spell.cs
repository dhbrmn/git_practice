// Spell.cs
using System;

namespace MagicalInheritance
{
    public abstract class Spell
    {
        public string Essence
        {
            get; protected set;
        }

        public bool IsStrong
        {
            get; protected set;
        }

        public string Caster
        {
            get; protected set;
        }

        public string Home
        {
            get; protected set;
        }

        public abstract string Announce();
    }
}
