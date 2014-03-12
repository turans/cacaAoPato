using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	void OnGUI (){
		if (GUI.Button (new Rect (20,20,150,100), "Jogar")) {
			Application.LoadLevel(1);
		}
	}
}
