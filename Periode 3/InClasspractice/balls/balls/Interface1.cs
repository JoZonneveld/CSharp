using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AssignmentComplete;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace balls
{
    interface Ball : IComponent
    {
        Vector2 Position { get; }
        Vector2 Velocity { get;  }
    }

    public class ControlBall : Ball
    {
        private Vector2 position;
        private Vector2 velocity;
        private Texture2D texture;
        public ControlBall(Texture2D texture)
        {
            this.texture = texture;
            position = new Vector2(0,0);
            velocity = new Vector2(0,0);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        public void Update(float dt)
        {
            position = position + velocity * dt;

            KeyboardState KeyBoardState = Keyboard.GetState();
            if (KeyBoardState.IsKeyDown(Keys.W))
            {
                velocity = new Vector2(0, 1);
            }
            else if (KeyBoardState.IsKeyDown(Keys.S))
            {
                velocity = new Vector2(0, -1);
            }
            else if (KeyBoardState.IsKeyDown(Keys.A))
            {
                velocity = new Vector2(-1, 0);
            }
            else if (KeyBoardState.IsKeyDown(Keys.W))
            {
                velocity = new Vector2(1, 0);
            }
            else
            {
                velocity = new Vector2(0,0);
            }
        }

        public Vector2 Position { get { return position; } }
        public Vector2 Velocity { get { return velocity; } }
    }
}
