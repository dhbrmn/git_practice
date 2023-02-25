using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            //DEFINE USER PROFILE
            Profile sam = new Profile("Sam Drakilla", 30, "New York", "USA", "he/him");
            
            //DEFINE HOBBIES
            sam.SetHobbies(new string[] { "listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns" });
            
            //WRITE PROFILE TO CONSOLE
            Console.WriteLine(sam.ViewProfile());
        }
    }
}

