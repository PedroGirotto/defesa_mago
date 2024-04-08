using Godot;
using System;

public partial class projetil_base : Node2D{
	private Node2D alvo;



	public override void _Ready(){
		//alvo = GetParent<mago_base>().get_alvo_atual();
		//GD.Print(alvo);
	}



	public override void _Process(double delta){
		//if(alvo != null){
		//	GD.Print(alvo);
		//}
	}
}
