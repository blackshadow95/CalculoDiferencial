using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System;

namespace CalculoDiferencial
{
    class Proyectil
    {
        public ContentManager content;
        Vector2 proyectilPosition;
        Texture2D proyectilTexture;
        private float v0 = 10;
        Enemy enemy;

        public Proyectil(ContentManager contentManager)
        {
            content = contentManager;
        }

        public void Initialize(Vector2 position)
        {
            proyectilPosition = position;
            proyectilTexture = content.Load<Texture2D>("sprites/proyectil");
        }

        public void Update()
        {
            
            proyectilPosition = new Vector2(proyectilPosition.X + 2, proyectilPosition.Y);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(proyectilTexture, proyectilPosition, null, Color.White, 0f, new Vector2(proyectilPosition.X / 2, proyectilPosition.Y / 2), new Vector2(.1f, .1f),SpriteEffects.None, 0f);
        }

    }
}
