using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssignmentComplete
{
    class Truck : ITruck
    {
        Texture2D texture;
        public IContainers Container { get; }
        public Vector2 position;
        public Vector2 Position { get { return position; } }
        public Vector2 Velocity { get; }

        public Truck(Texture2D texture, IContainers container, Vector2 position, Vector2 velocity)
        {
            this.texture = texture;
            IContainers Container = container;
            this.position = position;
            this.Velocity = velocity;
            AddContainer(Container);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Position, Color.White);
        }

        public void Update(float dt)
        {
            position += Velocity;
        }

        public void StartEngine()
        {
            //throw new NotImplementedException();
        }

        public void AddContainer(IContainers container)
        {
            
        }
    }

    class OreContainer : IContainers
    {
        public int getCurrentAmount { get; }
        public Vector2 position;
        public Vector2 getPosition { get { return position; } }
        Texture2D texture;

        public Vector2 Velocity = new Vector2(2,0);

        public OreContainer(Vector2 position, Texture2D texture)
        {
            this.position = position;
            this.texture = texture;
        }

        public void Update(float dt)
        {
            position += Velocity;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, getPosition, Color.White);
        }

        public void setPosition()
        {
            throw new NotImplementedException();
        }
    }
  
}
