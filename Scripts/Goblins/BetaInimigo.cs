using Godot;
using System;

public partial class BetaInimigo : Node2D{
	public override void _Ready(){
		
	}



	public override void _Process(double delta){
		Position += new Vector2(0.7f, 0f);
	}
}
