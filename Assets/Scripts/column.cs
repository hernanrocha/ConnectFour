using UnityEngine;
using System.Collections;

public class column : MonoBehaviour {

	//public ConnectFour game;
	public int id;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnMouseDown(){
		// Colocar ficha en la columna
		Debug.Log ("Colocar ficha en columna " + id);
		//game.addTween (id);
	}
}
