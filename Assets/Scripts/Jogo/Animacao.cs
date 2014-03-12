using UnityEngine;
using System.Collections;

public class Animacao : MonoBehaviour {

	private GameLoop glp;

	// Use this for initialization
	void Start () {
		glp = (GameLoop) FindObjectOfType (typeof(GameLoop));
	}
	
	// Update is called once per frame
	void Update () {

		if (glp.isAnimation == 1) {
			transform.position = Vector2.right * glp.OLDx + Vector2.up * glp.OLDy;
		}

		else {
			transform.position = Vector2.right * 20 + Vector2.up * 20;
		}
	}
}
