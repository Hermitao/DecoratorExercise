using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DecoratorExercise;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public static Texture2D atlas;
    public static SpriteFont font;

    CharacterConcrete character1;
    CharacterConcrete character2;

    public static Vector2 position;
    Vector2 scale;

    public static List<Character> characters = new List<Character>();

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        position = new Vector2(_graphics.PreferredBackBufferWidth / 2, 
            _graphics.PreferredBackBufferHeight / 2);
        scale = new Vector2(2f, 2f);

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        atlas = Content.Load<Texture2D>("adventurer-Sheet");
        font = Content.Load<SpriteFont>("Fonts/FiraMono");

        character1 = new CharacterConcrete(atlas, 11, 7, position + new Vector2(-100.0f, 0.0f), scale);
        character2 = new CharacterConcrete(atlas, 11, 7, position + new Vector2(25.0f, 0.0f), scale);
        HealthBarDecorator healthBarDecorator = new HealthBarDecorator(character2);

        characters.Add(character1);
        characters.Add(healthBarDecorator);


    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

        foreach (Character character in characters)
        {
            character.Update(deltaTime);
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(new Color(0.1f, 0.1f, 0.14f));

        foreach (Character character in characters)
        {
            character.Draw(_spriteBatch);
        }

        _spriteBatch.Begin();
        _spriteBatch.DrawString(
            DecoratorExercise.Game1.font, 
            String.Format("Exemplo de Decorator"), 
            new Vector2(16f, 16f), 
            Color.White
            );
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
