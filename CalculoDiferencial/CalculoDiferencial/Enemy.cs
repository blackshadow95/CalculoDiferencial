using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;


namespace CalculoDiferencial
{
    class Enemy
    {
        public ContentManager content;
        Texture2D enemyTexture;
        public Vector2 enemyPosition;
        bool moveRight = true;

        public Enemy(ContentManager contentManager, Vector2 position)
        {
            content = contentManager;
            enemyPosition = position;
        }

        public void Initialize()
        {
            enemyTexture = content.Load<Texture2D>("Sprites/enemy");
        }

        public void Update()
        {
            float currentPositionX = enemyPosition.X, currentPositionY = enemyPosition.Y;

            //if(moveRight == true)
            //    enemyPosition = new Vector2(currentPositionX + 5, currentPositionY);
            //else
            //    enemyPosition = new Vector2(currentPositionX - 5, currentPositionY);

            //if (currentPositionX == 600)
            //    moveRight = false;

            //else if(currentPositionX == 0)
            //    moveRight = true;

            enemyPosition = new Vector2()
                
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(enemyTexture, enemyPosition, null, Color.White, 0f, new Vector2(enemyPosition.X / 2, enemyPosition.Y / 2), new Vector2(.15f, .15f), SpriteEffects.None, 0f);
        }
    }
}
