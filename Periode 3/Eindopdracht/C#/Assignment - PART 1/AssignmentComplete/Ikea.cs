using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssignmentComplete
{
    class Ikea : IFactory
    {
        class AddOreBoxToMine : IAction
        {
            Ikea ikea;
            public AddOreBoxToMine(Ikea ikea)
            {
                this.ikea = ikea;
            }
            public void Run()
            {
                if (ikea.ProductsToShip.Count() == 3)
                {
                    ikea.productsToShip.Clear();

                }
                else if (ikea.ProductsToShip.Count() == 2)
                {
                    ikea.isTruckReady = true;
                }
                ikea.ProductsToShip.Add(CreateOreBox(ikea.Position + new Vector2(150, 40 + -30 * ikea.ProductsToShip.Count)));
            }
            Ore CreateOreBox(Vector2 position)
            {
                int Amount_Mines = 100 * ikea.ProductsToShip.Count();
                var box = new Ore(Amount_Mines, ikea.oreBox);
                box.Position = position;


                return box;
            }
        }

        Texture2D mine, oreContainer, oreBox, truckTexture;
        List<IStateMachine> processes;
        ITruck waitingTruck;
        OreContainer FullOreContainer;
        bool isTruckReady = false;
        Vector2 position;
        List<IContainer> productsToShip;

        public Ikea(Vector2 position, Texture2D truck_texture, Texture2D mine, Texture2D ore_box, Texture2D ore_container)
        {

            processes = new List<IStateMachine>();
            ProductsToShip = new List<IContainer>();
            this.mine = mine;
            this.truckTexture = truck_texture;
            this.oreContainer = ore_container;
            this.oreBox = ore_box;
            this.position = position;
            waitingTruck = new Truck(truckTexture, null, position + new Vector2(-100, 30), new Vector2(1, 0));

            processes.Add(
        new Repeat(new Seq(new Timer(1.0f),
                           new Call(new AddOreBoxToMine(this)))));
        }

        public ITruck getReadyContainer()
        {
            if (isTruckReady)
            {
                isTruckReady = false;
                return new OreContainer(oreContainer, null, position + new Vector2(-115, 8), new Vector2(-2, 0));
            }
            return null;
        }

        public ITruck GetReadyTruck()
        {
            if (isTruckReady)
            {
                return new Truck(truckTexture, null, position + new Vector2(-100, 30), new Vector2(-2, 0));
            }
            return null;
        }

        public Vector2 Position
        {
            get
            {
                return position;
            }
        }
        public List<IContainer> ProductsToShip
        {
            get
            {
                return productsToShip;
            }
            set
            {
                productsToShip = value;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var cart in ProductsToShip)
            {
                cart.Draw(spriteBatch);
            }
            if (productsToShip.Count() != 3)
            {
                waitingTruck.Draw(spriteBatch);
            }
            //FullOreContainer.Draw(spriteBatch);

            spriteBatch.Draw(mine, Position, Color.White);
        }
        public void Update(float dt)
        {
            foreach (var process in processes)
            {
                process.Update(dt);
            }
        }

    }
}