namespace RoverControlCenter
{
    class Probe
    {
        namespace RoverControlCenter
        {
        abstract class Probe
         {
              public string Alias
                {
                 get; protected set;
                }
        
             public abstract string GetInfo();
             public abstract string Explore();
             public abstract string Collect();       
        }
       }
   }
}
