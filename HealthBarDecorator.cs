using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

public class HealthBarDecorator : CharacterDecorator
{
    public float timer;

    public HealthBarDecorator(Character character) : base(character) {}

    public override void Update(float deltaTime)
    {
        base.Update(deltaTime);

        timer += deltaTime;
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        base.Draw(spriteBatch);

        spriteBatch.Begin();
        spriteBatch.DrawString(
            DecoratorExercise.Game1.font, 
            String.Format("HP: {0:0}", (MathF.Sin(timer * 1.0f) * 0.5f + 0.5f) * 100f), 
            DecoratorExercise.Game1.position + new Vector2(45f, -12f), 
            Color.Red
            );
        spriteBatch.End();
    }
}