// Pupil.cs
using System;

namespace MagicalInheritance
{
    public class Pupil
    {
        public string Title
        {
            get; protected set;
        }

        public string Origin
        {
            get; protected set;
        }


        public Pupil( string title, string origin )
        {
            Title = title;
            Origin = origin;
        }

        public Storm CastWindStorm()
        {
            Storm windStorm = new Storm("wind", false, Title, Origin);
            return windStorm;
        }
    }
}

