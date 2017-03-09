namespace Exercise2
{
    public class Gasoline : Fuel
    {
        public double Price { get; set; }
        public string fuelkind = "Gasoline";
        public string FuelKind { get { return fuelkind; } }

        public Gasoline()
        {
            this.Price = 1.49;
        }
    }
}