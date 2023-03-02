// Storm.cs
using System;

namespace MagicalInheritance
{
    public class Storm
    {

        public string Essence
        {
            get; private set;
        }

        public bool IsStrong
        {
            get; private set;
        }

        public string Caster
        {
            get; private set;
        }

        public string Home
        {
            get; private set;
        }

        public Storm( string essence, bool isStrong, string caster, string home )
        {
            Essence = essence.ToLower();
            IsStrong = isStrong;
            Caster = caster;
            Home = home;
        }

        public string Announce()
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
