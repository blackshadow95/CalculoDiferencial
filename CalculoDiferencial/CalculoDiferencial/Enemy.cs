using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System;


namespace CalculoDiferencial
{
    class Enemy
    {

        public ContentManager content;
        Texture2D enemyTexture;
        public Vector2 enemyPosition;
        public enum type {eliptico, horizontal, horizontal2, vertical, vertical2};
        type myType;
        private int x = 0, alcanceX = 700, alcanceY = 450;
        private float t = .1f, amplitudH = 20, amplitudV = 10;
        private int speed = 10;

        public Enemy(ContentManager contentManager, Vector2 position, type _myType)
        {
            content = contentManager;
            enemyPosition = position;
            myType = _myType;
        }

        public void Initialize()
        {
            enemyTexture = content.Load<Texture2D>("Sprites/enemy");
        }

        public void Update()
        {
            GetMovement();
        }


        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(enemyTexture, enemyPosition, null, Color.White, 0f, new Vector2(enemyPosition.X / 2, enemyPosition.Y / 2), new Vector2(.15f, .15f), SpriteEffects.None, 0f);
        }

        private void GetMovement()
        {
            if (myType == type.vertical)
            {
                enemyPosition = new Vector2(enemyPosition.X, (enemyPosition.Y + 2) + speed + t);
                if (enemyPosition.Y >= alcanceY)
                {
                    myType = type.vertical2;
                }
            }

            else if (myType == type.vertical2)
            {
                enemyPosition = new Vector2(enemyPosition.X, (enemyPosition.Y - 2) - speed - t);
                if (enemyPosition.Y <= 0)
                {
                    myType = type.vertical;
                }
            }

            else if (myType == type.horizontal)
            {
                enemyPosition = new Vector2((enemyPosition.X + 2) + speed + t, enemyPosition.Y);
                if (enemyPosition.X >= alcanceX)
                {
                    myType = type.horizontal2;
                }
            }

            else if (myType == type.horizontal2)
            {
                enemyPosition = new Vector2((enemyPosition.X - 2) - speed - t, enemyPosition.Y);
                if (enemyPosition.X <= 0)
                {
                    myType = type.horizontal;
                }
            }

            else if (myType == type.eliptico)
            {
                enemyPosition = new Vector2(enemyPosition.X + (float)Math.Cos(x * .1) * 10, enemyPosition.Y + (float)Math.Sin(x * .1));
            }

            t += .01f;
            x++;
        }

    }
}
