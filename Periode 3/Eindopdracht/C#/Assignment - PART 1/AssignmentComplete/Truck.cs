﻿using System;
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
        public IContainer Container { get; }
        public Vector2 position;
        public Vector2 Position { get { return position; } }
        public Vector2 Velocity { get; }

        public Truck(Texture2D texture, IContainer container, Vector2 position, Vector2 velocity)
        {
            this.texture = texture;
            IContainer Container = container;
            this.position = position;
            this.Velocity = velocity;
            //AddContainer(Container);
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

        public void AddContainer(IContainer container)
        {
            
        }
    }

    class OreContainer : IContainer
    {
        public void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public int CurrentAmount { get; }
        public int MaxCapacity { get; }
        public bool AddContent(int amount)
        {
            throw new NotImplementedException();
        }

        public Vector2 Position { get; set; }
    }
  
}
