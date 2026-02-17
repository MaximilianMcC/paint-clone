using Raylib_cs;

class CameraHandler
{
	private static readonly float zoomSensitivity = 0.05f;
	private static readonly float scrollSensitivity = 30f;

	public static void Update(ref Camera2D camera)
	{
		// Check for if we've scrolled
		float scrollDirection = Raylib.GetMouseWheelMoveV().Y;
		if (scrollDirection == 0f) return;

		if (Raylib.IsKeyDown(KeyboardKey.LeftControl))
		{
			// Check for if we wanna move left/right
			//? ctrl + scroll up moves the canvas right
			camera.Target.X += -scrollDirection * scrollSensitivity;
		}
		else if (Raylib.IsKeyDown(KeyboardKey.LeftAlt))
		{
			// Check for if we wanna zoom in
			//? alt + scroll up zooms in
			camera.Zoom += Raylib.GetMouseWheelMoveV().Y * zoomSensitivity;
		}
		else
		{
			// Check for if we wanna move up/down
			//? scroll up moves the canvas down
			camera.Target.Y += -Raylib.GetMouseWheelMoveV().Y * scrollSensitivity;
		}
	}
}