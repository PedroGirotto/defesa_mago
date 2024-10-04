using Godot;
using System;

public partial class MapaBase : Node2D{
	private Camera2D camera;
	private TileMap mapa;
	private Rect2I area;



	public override void _Ready(){
		mapa = GetNode<TileMap>("terra");
		camera = GetNode<Camera2D>("camera");

		ConfigurarCamera();
	}



	public override void _Process(double delta){
	}



	/*
	* função responsável por pegar a camera o tileset do Node principal
	* pega o tamanho de uma célula do tileset e calcula o tamanho total do mapa
	* assim reajustando o zoom da camera para encaixar o tamanho do mapa na tela.
	*/
	private void ConfigurarCamera(){
		area = mapa.GetUsedRect();
		float comprimento_area = area.Size.X*mapa.TileSet.TileSize.X; // 16 é o tamanho do pixel do tileset
		float altura_area = area.Size.Y*mapa.TileSet.TileSize.Y; // 16 é o tamanho do pixel do tileset
		
		camera.AnchorMode = 0; // o pivô é o canto esquerdo superior
		camera.Position = new Vector2(0,0);
		float zoom_x = camera.GetViewportRect().Size.X/comprimento_area;
		float zoom_y = camera.GetViewportRect().Size.Y/altura_area;
		camera.Zoom = new Vector2(zoom_x, zoom_y);
	}
}
