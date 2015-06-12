using UnityEngine;
using System.Collections;

public class column : MonoBehaviour {

	public Board game;
	public int id;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnMouseDown(){
		// Colocar ficha en la columna
		game.addFicha (id);
	}
}
