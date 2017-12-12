using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using CommonDataItems;
using Engine.Engines;
using Microsoft.Xna.Framework.Input;
using Microsoft.AspNet.SignalR.Client;

namespace MonoGameClient.GameObjects
{
    public class Coin : DrawableGameComponent
    {
        public Texture2D CoinImage;
        public Point Position;
        public Rectangle boundingRect;
        public bool Visible = true;
        public int scoreValue = 1;

        public Coin(Game game, Texture2D image, Point pos) : base(game)
        {
            CoinImage = image;
            Position = pos;

        }

        public override void Update(GameTime gameTime)
        {
           
            base.Update(gameTime);
        }



    }


}