using Godot;
using System;

public partial class ProjetilBase : Node2D{
	private float velocidadeProjetil;
	private Node2D alvo;



	public override void _Ready(){
		GlobalPosition = GetParent<Node2D>().GlobalPosition;

		alvo = GetParent<MagoBase>().getAlvoAtual();
		velocidadeProjetil = 100f;
	}



	public override void _PhysicsProcess(double delta){
		if(alvo != null){
			GlobalPosition += GlobalPosition.DirectionTo(alvo.GlobalPosition) * (float)delta*velocidadeProjetil;
		}
	}



	//* sinais
	private void OnAreaEntered(Area2D body){
		if(body.GetParent<Node2D>().IsInGroup(GerenteGrupos.Instance.goblins) && body.GetParent<Node2D>() == alvo){
			//! TIRAR VIDA DO MONSTRO!
			body.GetParent<Node2D>().QueueFree(); //! ISSO É SÓ PARA TESTE
			QueueFree();
		}
	}
}