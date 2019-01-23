using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System;
using CalculoDiferencial;
using System.Collections.Generic;

namespace CalculoDiferencial
{
    class Canon
    {
        public ContentManager content;
        Texture2D canonTexture;
        Vector2 canonPosition;
        Proyectil proyectil;
        List<Proyectil> proyectilList;

        public Canon(ContentManager contentManager)
        {
            content = contentManager;
            canonPosition = new Vector2(0, 200);
            proyectilList = new List<Proyectil>();
        }

        public void Initialize()
        {
            canonTexture = content.Load<Texture2D>("Sprites/canon");
        }

        public void Update()
        {
            if(Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                Shoot();
            }

            foreach(Proyectil _proyectil in proyectilList)
            {
                _proyectil.Update();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(canonTexture, canonPosition, null, Color.White, 0f, new Vector2(canonPosition.X / 2, canonPosition.X / 2), new Vector2(.15f, .15f), SpriteEffects.None, 0f);
            foreach(Proyectil _proyectil in proyectilList)
            {
                _proyectil.Draw(spriteBatch);
            }
        }

        void Shoot()
        {
            proyectil = new Proyectil(content);
            proyectil.Initialize(canonPosition);
            proyectilList.Add(proyectil);
        }
    }
}
