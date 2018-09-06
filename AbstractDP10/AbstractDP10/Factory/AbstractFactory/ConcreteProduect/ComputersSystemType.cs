namespace AbstractDP10.Factory.AbstractFactory
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.ComputerType.Laptop.ToString();
        }
    }

    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.ComputerType.Desktop.ToString();
        }
    }
}
