using Godot;
using System;

public partial class Spawn : Node2D{
	private PackedScene goblins;



	public override void _Ready(){
		goblins = GD.Load<PackedScene>("res://Cenarios/Goblins/beta_inimigo.tscn");
	}



	public override void _Process(double delta){
	}



	private void OnTimeOut(){
		AddChild(goblins.Instantiate());
	}
}
