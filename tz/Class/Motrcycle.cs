namespace tz.Class
{
    internal class Motrcycle : Transport
    {
        public override string MakeSound()
        {
            return "Motrcycle makes a sound";
        }

        private string _model;

        public override string Model
        {
            get { return _model; }
            set { _model = value; }
        }

    }
}
