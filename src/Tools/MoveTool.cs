using Raylib_cs;

class MoveTool : Tool
{
	public override string Name => "Move";
	public override KeyboardKey ShortcutKey => KeyboardKey.V;

	public override void Equip() => Console.WriteLine("move");
	public override void Use() { }
	public override void Unequip() { }
}