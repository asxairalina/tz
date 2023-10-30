namespace tz.Class
{
    internal class Boat : Transport
    {
        public override void Speed()
        {
            Console.WriteLine($"Boat - {Wheels} не имеет");
        }
    }
}