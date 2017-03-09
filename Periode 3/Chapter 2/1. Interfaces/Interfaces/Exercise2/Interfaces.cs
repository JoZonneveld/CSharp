namespace Exercise2
{
    public interface Vehicle
    {
        void Move();
        void LoadFuel();
        double Tank { get; set; }
        double TankCapacity { get; set; }
        int FuelEconomy { get; set; }
    }

    public interface Fuel
    {
        double Price { get; set; }
        string FuelKind { get; }
    }
}