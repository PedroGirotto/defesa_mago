using Godot;
using System;

public partial class beta_inimigo : Node2D{
	public override void _Ready(){
	}



	public override void _Process(double delta){
		Position += new Vector2(1.0f, 0f);
	}
}
