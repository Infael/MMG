using Microsoft.Xna.Framework;

namespace MMG.Graphics;

public class Camera(int viewportWidth, int viewportHeight)
{
  public Vector2 Position { get; set; } = Vector2.Zero;
  public float Zoom { get; set; } = 1.0f;
  public float Rotation { get; set; } = 0.0f;

  public int ViewportWidth = viewportWidth;
  public int ViewportHeight = viewportHeight;

  public Matrix GetViewMatrix()
  {
    return
        Matrix.CreateTranslation(new Vector3(-Position.X, -Position.Y, 0)) *
        Matrix.CreateRotationZ(Rotation) *
        Matrix.CreateScale(Zoom) *
        Matrix.CreateTranslation(new Vector3(ViewportWidth / 2f, ViewportHeight / 2f, 0));
  }

  public void FollowPosition(Vector2 followedPosition, float smoothing = 0.1f, bool useSmoothing = true)
  {
    if (!useSmoothing)
    {
      Position = followedPosition;
      return;
    }
    Position = Vector2.Lerp(Position, followedPosition, smoothing);
  }
}