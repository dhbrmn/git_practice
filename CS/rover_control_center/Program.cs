using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main( string[] args )
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] rovers = new Rover[] { lunokhod, apollo, sojourner };
            DirectAll(rovers);

          /*IDirectable[] probes = new IDirectable[] { lunokhod, apollo, sojourner, sputnik };
            foreach (IDirectable p in probes)
            {
                Console.WriteLine(p.GetInfo());
                Console.WriteLine(p.Explore());
                Console.WriteLine(p.Collect());
            }*/
            Probe[] probes = new Probe[] {lunokhod, apollo, sojourner, sputnik};
            foreach (Probe p in probes)
               {
                Console.WriteLine(p.GetInfo());
                Console.WriteLine(p.Explore());
                Console.WriteLine(p.Collect());
               }

        }

        public static void DirectAll( /*IDirectable*/Probe[] probes)
        {
            foreach (/*IDirectable*/Probe p in probes)
            {
                Console.WriteLine(p.GetInfo());
                Console.WriteLine(p.Explore());
                Console.WriteLine(p.Collect());
            }      
        }
    }
}
