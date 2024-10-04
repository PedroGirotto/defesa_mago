using Godot;
using Godot.Collections;
using System;

public partial class MagoBase : Node2D{
	private Array<Node2D> alvoGoblins;
	private PackedScene ataque;
	
	
	
	//! ignorar por enquanto
	private enum prioridade_ataque{
		primeiro,
		ultimo,
		aleatorio
	}



	public override void _Ready(){
		alvoGoblins = new Array<Node2D>();
		ataque = GD.Load<PackedScene>("res://Cenarios/Magos/Projeteis/projetil_base.tscn");
	}



	public override void _Process(double delta){
	}



	//* funções de apoio
	public Node2D getAlvoAtual(){
		if(alvoGoblins.Count > 0){
			return alvoGoblins[0];
		}
		else{
			return null;
		}
	}



	//* sinais
	private void OnAreaEnteredVisao(Area2D body){
		if(body.GetParent<Node2D>().IsInGroup(GerenteGrupos.Instance.goblins)){
			alvoGoblins.Add(body.GetParent<Node2D>());
		}
		CallDeferred("add_child", ataque.Instantiate()); //! entender o porque disso aqui!!!!
	}



	private void OnAreaExitedVisao(Area2D body){
		alvoGoblins.Remove(body.GetParent<Node2D>());
	}
}