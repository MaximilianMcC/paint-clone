using Raylib_cs;

class BrushTool : Tool
{
	public override string Name => "Brush";
	public override KeyboardKey ShortcutKey => KeyboardKey.B;

	public override void Equip()
	{
		Console.WriteLine("brush");
	}

	public override void Use()
	{
		
	}

	public override void Unequip()
	{
		
	}
}