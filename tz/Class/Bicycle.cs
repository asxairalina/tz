namespace tz.Class
{
    internal class Bicycle : Transport
    {
        public override string MakeSound()
        {
            return "Bicycle makes a sound";
        }

        private string _model;

        public override string Model
        {
            get { return _model; }
            set { _model = value; }
        }

    }
}
