﻿using System;

namespace Exercise2
{
    public class Car : Vehicle
    {
        public double Tank { get; set; }
        public int FuelEconomy { get; set; }
        public double TankCapacity { get; set; }
        public Gasoline Fuel;

        public Car(double tank, int FuelEconomy)
        {
            this.Tank = tank;
            this.FuelEconomy = FuelEconomy;
            this.TankCapacity = Tank;
            this.Fuel = new Gasoline();
        }

        public void Move()
        {
            double x = 1.0 / FuelEconomy;
            x /= 10;
            
            if (Tank <= 0)
            {
                Console.WriteLine("U moet tanken");
            }
            else
            {
                Tank -= x;
                Console.WriteLine(Tank);
            }
        }

        public void LoadFuel()
        {
            if (Fuel.FuelKind == "Gasoline")
            {
                double x;
                x = TankCapacity - Tank;
                x = x * Fuel.Price;
                Console.WriteLine("U moet " + x + " betalen");
            }
            else
            {
                Console.WriteLine("U heeft de verkeerde brandstof");
            }
        }
    }
}