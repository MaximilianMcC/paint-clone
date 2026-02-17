using Raylib_cs;

class Program
{
	public static void Main(string[] args)
	{
		Raylib.SetConfigFlags(ConfigFlags.ResizableWindow);
		Raylib.InitWindow(1920, 1080, "painting rn");

		Canvas.Start();

		// Register all the tools
		// TODO: Do this another way (maybe dynamic)
		ToolHandler.Tools.Add(new MoveTool());
		ToolHandler.Tools.Add(new BrushTool());

		while (Raylib.WindowShouldClose() == false)
		{
			Canvas.Update();
			ToolHandler.Update();

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