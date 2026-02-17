using Raylib_cs;

class Program
{
	public static void Main(string[] args)
	{
		Raylib.SetConfigFlags(ConfigFlags.ResizableWindow);
		Raylib.InitWindow(1920, 1080, "painting rn");

		Canvas.Start();

		while (Raylib.WindowShouldClose() == false)
		{
			Canvas.Update();

			Raylib.ClearBackground(Color.Black);
			Raylib.BeginDrawing();
			Canvas.Render();
			TextDrawer.BeginDrawing();
			Raylib.EndDrawing();
		}

		Canvas.Unload();
		Raylib.CloseWindow();
	}
}