namespace tz.Class
{
    internal class Boat : Transport
    {
        public override string MakeSound()
        {
            return "Boat makes a sound";
        }

        private string _model;

        public override string Model
        {
            get { return _model; }
            set { _model = value; }
        }

    }
}