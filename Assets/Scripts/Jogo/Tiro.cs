using UnityEngine;
using System.Collections;

public class Tiro : MonoBehaviour {

	private GameLoop glp;

	// Use this for initialization
	void Start () {
		glp = (GameLoop) FindObjectOfType (typeof(GameLoop));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GetComponent<AudioSource>().Play();
		}
		if (glp.miss == 1) {
			if (glp.score >= 5) glp.score -= 5;
			float x = (Input.mousePosition.x * 15)/960;
			float y = (Input.mousePosition.y * 9)/600;
			transform.position = Vector2.right * x + Vector2.up * y;
			glp.miss = 2;
		}

		else if (glp.miss == 0) {
			transform.position = Vector2.right * 20 + Vector2.up * 20;
		}
	}
}
