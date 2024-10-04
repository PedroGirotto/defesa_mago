using Godot;
using System;

/*
* Objetivo dessa classe é de tirar a dependencia com o nome dos grupos.
*/

public partial class GerenteGrupos : Node
{
	public static GerenteGrupos Instance { get; private set; }

    public string goblins { get; private set; }

    public override void _Ready()
    {
        goblins = "Goblins";
        Instance = this;
    }
}
