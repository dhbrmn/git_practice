using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main( string[] args )
        {
            Pupil mezilKree = new Pupil("Mezil-kree", "Icecrown");

            Mage gulDan = new Mage("Gul'Dan", "Draenor");

            Archmage nielasAran = new Archmage("Nielas Aran", "Stormwind");

            Storm[] storm = new Storm[10];
            storm[0] = mezilKree.CastWindStorm();
            storm[1] = gulDan.CastRainStorm();
            storm[2] = nielasAran.CastRainStorm();
            storm[3] = nielasAran.CastLightningStorm();




            for (int stormIndex = 0; stormIndex < 10; stormIndex++)
            {
                if (storm[stormIndex] != null)
                {
                    Console.WriteLine(storm[stormIndex].Announce());
                }
            }

        }
    }
}