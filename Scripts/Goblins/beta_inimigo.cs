using Godot;
using System;

public partial class beta_inimigo : Node2D{
	public override void _Ready(){
		GD.Print("Goblin Position: " + GlobalPosition);
	}



	public override void _Process(double delta){
		Position += new Vector2(0.7f, 0f);
	}
}
