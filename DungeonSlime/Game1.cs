using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace DungeonSlime;

public class Game1 : Core
{
    private Texture2D _logo;

    public Game1() : base("Dungeon Slime", 1280, 720, false)
    {
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _logo = Content.Load<Texture2D>("images/logo");
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // the bounds of the icon within the texture
        Rectangle iconSourceRect = new Rectangle(0, 0, 128, 128);
        // the bounds of the wordmark within the texture
        Rectangle wordmarkSourceRect = new Rectangle(150, 34, 458, 58);

        // TODO: Add your drawing code here
        SpriteBatch.Begin(sortMode: SpriteSortMode.BackToFront);
        SpriteBatch.Draw(_logo, // texture
            new Vector2( // position
                Window.ClientBounds.Width,
                Window.ClientBounds.Height) * 0.5f,
            iconSourceRect, // source rectangle
            Color.White, // color
            0.0f, // rotation
            new Vector2(iconSourceRect.Width * 0.5f, iconSourceRect.Height * 0.5f), // origin - origin of the texture... like the pivot point
            1.0f, // scale
            SpriteEffects.None, // effects
            0.5f // layer depth - for sorting
            );

        SpriteBatch.Draw(_logo, // texture
            new Vector2( // position
                Window.ClientBounds.Width * 0.5f,
                Window.ClientBounds.Height * 0.5f),
            wordmarkSourceRect, // source rectangle
            Color.White, // color
            0.0f, // rotation
            new Vector2(wordmarkSourceRect.Width * 0.5f, wordmarkSourceRect.Height * 0.5f), // origin - origin of the texture... like the pivot point
            1.0f, // scale
            SpriteEffects.None, // effects
            0.55f // layer depth - for sorting
            );

        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
