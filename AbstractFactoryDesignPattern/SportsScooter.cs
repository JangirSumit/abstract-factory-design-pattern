namespace AbstractFactoryDesignPattern
{
    internal class SportsScooter : IScooter
    {
        public string GetScooterName(string name)
        {
            return $"Sports Scooter - {name}";
        }
    }
}