namespace RoverControlCenter
{
    class Satellite : Probe /*IDirectable*/
    {
       /* public string Alias
        {
            get; private set;
        }*/

        public int YearLaunched
        {
            get; private set;
        }

        public Satellite( string alias, int yearLaunched )
        {
            Alias = alias;
            YearLaunched = yearLaunched;
        }

        public override string GetInfo()
        {
            return $"Alias: {Alias}, YearLaunched: {YearLaunched}";
        }

        public override string Explore()
        {
            return "Satellite is exploring the far reaches of space!";
        }

        public override string Collect()
        {
            return "Satellite is collecting photographic evidence!";
        }
    }
}
