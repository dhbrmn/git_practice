using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main( string[] args )
        {
            Storm wind = new Storm("wind", false, "Zul'rajas");
            Console.WriteLine(wind.Announce());

            Pupil mezilKree = new Pupil("Mezil-kree");
            Storm mezilWind = mezilKree.CastWindStorm();
            Console.WriteLine(mezilWind.Announce());

            Mage gulDan = new Mage("Gul'Dan");
            Storm gulRain = gulDan.CastRainStorm();
            Console.WriteLine(gulRain.Announce());

            Archmage nielasAran = new Archmage("Nielas Aran");
            Storm nielRain = nielasAran.CastRainStorm();
            Storm nielLightning = nielasAran.CastLightningStorm();
            Console.WriteLine(nielRain.Announce());
            Console.WriteLine(nielLightning.Announce());

        }
    }
}