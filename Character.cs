using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

public abstract class Character
{
    public abstract void Update(float deltaTime);

    public abstract void Draw(SpriteBatch spriteBatch);
}