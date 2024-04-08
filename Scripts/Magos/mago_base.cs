using Godot;
using Godot.Collections;
using System;

public partial class mago_base : Node2D{
	private Array<Node2D> goblins_alvos;
	private PackedScene ataque;
	
	
	
	//! ignorar por enquanto
	private enum prioridade_ataque{
		primeiro,
		ultimo,
		aleatorio
	}



	public override void _Ready(){
		goblins_alvos = new Array<Node2D>();
		ataque = GD.Load<PackedScene>("res://Cenarios/Magos/Projeteis/projetil_base.tscn");
	}



	public override void _Process(double delta){
	}



	//* funções de apoio
	public Node2D get_alvo_atual(){
		if(goblins_alvos.Count > 0){
			return goblins_alvos[0];
		}
		else{
			return null;
		}
	}



	//* Sinais
	private void OnAreaEnteredVisao(Area2D body){
		if(body.IsInGroup("Goblins")){
			goblins_alvos.Add(body.GetParent<Node2D>());
		}
		GD.Print(goblins_alvos[0]);
		GD.Print(goblins_alvos.Count);
		CallDeferred("add_child", ataque.Instantiate()); //! entender o porque disso aqui!!!!
	}



	private void OnAreaExitedVisao(Area2D body){
		goblins_alvos.Remove(body.GetParent<Node2D>());
	}
}