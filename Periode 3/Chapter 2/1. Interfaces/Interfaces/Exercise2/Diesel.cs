namespace Exercise2
{
    public class Diesel : Fuel
    {
        public double Price { get; set; }
        public string fuelkind = "Diesel";
        public string FuelKind { get { return fuelkind; } }

        public Diesel()
        {
            this.Price = 1.49;
        }
    }
}