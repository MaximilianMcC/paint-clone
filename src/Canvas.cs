using System.Numerics;
using Raylib_cs;

class Canvas
{
	private static Camera2D Camera;
	private static RenderTexture2D ActualCanvas;

	public static void Start()
	{
		// Make the canvas and set a white background
		ActualCanvas = Raylib.LoadRenderTexture(1920, 1080);
		Raylib.BeginTextureMode(ActualCanvas);
		Raylib.ClearBackground(Color.White);

		//! Draw a debug dot in the centre of the canvas
		Raylib.DrawCircleV(ActualCanvas.Texture.Dimensions, 5f, Color.Magenta);
		
		Raylib.EndTextureMode();

		// Make the camera
		// TODO: Do this in the camera class
		Camera = new Camera2D(
			Vector2.Zero,
			ActualCanvas.Texture.Dimensions / 2f,
			0f,
			1f
		);
	}

	public static void Update()
	{
		CameraHandler.Update(ref Camera);
	}

	public static void Render()
	{
		Raylib.BeginMode2D(Camera);
		Raylib.DrawTexture(ActualCanvas.Texture, 0, 0, Color.White);
		Raylib.EndMode2D();
	}

	public static void Unload()
	{
		Raylib.UnloadRenderTexture(ActualCanvas);
	}
}