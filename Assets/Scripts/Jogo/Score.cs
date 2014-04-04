using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	public GameInfo instanceGI;

	// Use this for initialization
	void Start () {
		instanceGI = (GameInfo)FindObjectOfType (typeof(GameInfo));
	}
	bool ok = false;
	// Update is called once per frame
	void Update () {
		if (ok && instanceGI.nrPatos < 6) {
			instanceGI.aumentaScore();
			ok = false;
		}
		if (instanceGI.nrPatos == 6) ok = true;
		if (instanceGI.miss) {
			instanceGI.diminuiScore();
			instanceGI.miss = false;
		}
	}
}
