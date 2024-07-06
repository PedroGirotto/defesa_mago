using Godot;
using System;

public partial class projetil_base : Node2D{
	private float velocidade_projetil;
	private Node2D alvo;



	public override void _Ready(){
		GlobalPosition = GetParent<Node2D>().GlobalPosition;

		alvo = GetParent<mago_base>().get_alvo_atual();
		velocidade_projetil = 100f;
	}



	public override void _PhysicsProcess(double delta){
		if(alvo != null){
			GlobalPosition += GlobalPosition.DirectionTo(alvo.GlobalPosition) * (float)delta*velocidade_projetil;
		}
	}



	//* sinais
	private void OnAreaEntered(Area2D body){
		if(body.IsInGroup("Goblins") && body == alvo){
			//! TIRAR VIDA DO MONSTRO!
			QueueFree();
		}
	}
}