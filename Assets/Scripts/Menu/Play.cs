using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	void OnMouseEnter(){
		print ("Hey");
		renderer.material.color = Color.black;
	}

	void OnMouseExit(){
		renderer.material.color = Color.white;
	}

	void OnMouseUp(){
		Application.LoadLevel(1);
	}
}
