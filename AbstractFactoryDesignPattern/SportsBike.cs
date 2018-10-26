namespace AbstractFactoryDesignPattern
{
    internal class SportsBike : IBike
    {
        public string GetBikeName(string name)
        {
            return $"Sports Bike - {name}";
        }
    }
}