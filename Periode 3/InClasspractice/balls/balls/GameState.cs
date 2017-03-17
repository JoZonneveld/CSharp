using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace balls
{
    public class GameState : IComponent
    {
        private Ball ball;

        public GameState(Texture2D ball_texture)
        {
            ball = new ControlBall(ball_texture);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            ball.Draw(spriteBatch);
        }

        public void Update(float dt)
        {
            throw new NotImplementedException();
        }
    }
}