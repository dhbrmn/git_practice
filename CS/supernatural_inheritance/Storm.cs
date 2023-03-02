// Storm.cs
using System;

namespace MagicalInheritance
{
    public class Storm : Spell
    {

        public Storm( string essence, bool isStrong, string caster, string home )
        {
            Essence = essence.ToLower();
            IsStrong = isStrong;
            Caster = caster;
            Home = home;
        }

        public override string Announce()
        {
            if (IsStrong == true)
            {
                return $"{Caster} from {Home} cast a strong {Essence} storm!";
            }
            else
            {
                return $"{Caster} from {Home} cast a weak {Essence} storm.";
            }

        }

    }
}
