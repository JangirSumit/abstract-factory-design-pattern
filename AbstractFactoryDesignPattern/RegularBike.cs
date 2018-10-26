namespace AbstractFactoryDesignPattern
{
    internal class RegularBike : IBike
    {
        public string GetBikeName(string name)
        {
            return $"Regular Bike - {name}";
        }
    }
}