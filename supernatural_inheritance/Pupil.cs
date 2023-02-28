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

        public Pupil( string title )
        {
            Title = title;
        }

        public Storm CastWindStorm()
        {
            Storm windStorm = new Storm("wind", false, Title);
            return windStorm;
        }
    }
}

