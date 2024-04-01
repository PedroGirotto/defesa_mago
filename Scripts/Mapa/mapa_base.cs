using Godot;
using System;

public partial class mapa_base : Node2D{
	// TODO: descobrir uma maneira descente de pegar os componentes direto por código
	[Export]
	Camera2D camera;

	[Export]
	TileMap mapa;

	
	Rect2I area;



	public override void _Ready(){
		ConfigurarCamera();
	}



	public override void _Process(double delta){
	}



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
