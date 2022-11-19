using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class CharacterDecorator : Character
{
    public Character character = null;

    public CharacterDecorator(Character character)
    {
        this.character = character;
    }

    public override void Update(float deltaTime)
    {
        character.Update(deltaTime);
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        character.Draw(spriteBatch);
    }

}