namespace AbstractFactoryDesignPattern
{
    internal class RegularScooter : IScooter
    {
        public string GetScooterName(string name)
        {
            return $"Regular Scooter - {name}";
        }
    }
}