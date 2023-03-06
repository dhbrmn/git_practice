namespace RoverControlCenter
{
    class Rover : Probe /*IDirectable*/
    {
        /*public string Alias
        {
            get; private set;
        }*/

        public int YearLanded
        {
            get; private set;
        }

        public Rover( string alias, int yearLanded )
        {
            Alias = alias;
            YearLanded = yearLanded;
        }

        public override string GetInfo()
        {
            return $"Alias: {Alias}, YearLanded: {YearLanded}";
        }

        public override string Explore()
        {
            return "Rover is exploring the surface!";
        }

        public override string Collect()
        {
            return "Rover is collecting rocks!";
        }
    }
}
