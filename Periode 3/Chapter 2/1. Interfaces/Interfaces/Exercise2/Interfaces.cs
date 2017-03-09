namespace Exercise2
{
    public interface Vehicle
    {
        void Move();
        void LoadFuel();
    }

    public interface Fuel
    {
        float tank { get; set; }
    }
}