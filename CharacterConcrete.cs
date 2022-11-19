using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class CharacterConcrete : Character
{
    public AnimatedSprite animatedSprite;
    public Vector2 position;
    public Vector2 scale;

    public CharacterConcrete(Texture2D spriteSheet, int rows, int columns, Vector2 position, Vector2 scale)
    {
        this.position = position;
        this.scale = scale;
        animatedSprite = new AnimatedSprite(spriteSheet, rows, columns);
    }

    public override void Update(float deltaTime)
    {
        animatedSprite.Update(deltaTime);
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        animatedSprite.Draw(spriteBatch, position, scale);
    }
}