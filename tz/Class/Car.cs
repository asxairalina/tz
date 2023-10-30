namespace tz.Class
{
    internal class Car : Transport
    {
        public override string MakeSound()
        {
            return "Car makes a sound";
        }

        private string _model;

        public override string Model
        {
            get { return _model; }
            set { _model = value; }
        }

    }
}