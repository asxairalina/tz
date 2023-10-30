namespace tz.Class
{
    internal class Scooter : Transport
    {
        public override string MakeSound()
        {
            return "Scooter makes a sound";
        }

        private string _model;

        public override string Model
        {
            get { return _model; }
            set { _model = value; }
        }


    }
}
