using Raylib_cs;

abstract class Tool
{
	public abstract string Name { get; }
	public abstract KeyboardKey ShortcutKey { get; }

	public abstract void Equip();
	public abstract void Use();
	public abstract void Unequip();
}

class ToolHandler
{
	public static List<Tool> Tools = [];
	public static Tool SelectedTool { get; private set; }

	public static void Update()
	{
		// Make sure we have a tool
		// TODO: Don't do this
		if (SelectedTool == null) SelectedTool = Tools[0];

		// Check for if we're switching tools
		foreach (Tool tool in Tools)
		{
			if (Raylib.IsKeyPressed(tool.ShortcutKey))
			{
				// Stop using the old tool
				SelectedTool.Unequip();

				// Use the new tool
				SelectedTool = tool;
				SelectedTool.Equip();
			}
		}

		// Use the current tool
		SelectedTool.Use();
	}
}