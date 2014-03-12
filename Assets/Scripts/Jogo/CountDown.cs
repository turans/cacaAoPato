using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

	float startTime;
	int restSeconds;
	int countDownSeconds;

	// Use this for initialization
	void Start () {
		startTime = (float) Time.time;
		countDownSeconds = 30;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

		float actualTime = (float) (Time.time) - startTime;
		restSeconds = countDownSeconds - (int) actualTime;

		if (restSeconds == 0) {
			Application.LoadLevel(2);
		}
		GUI.Label(new Rect(10,5,200,20), "Tempo restante: " + restSeconds);

	}

}