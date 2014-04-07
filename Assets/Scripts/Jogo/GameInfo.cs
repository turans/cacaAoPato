using UnityEngine;
using System.Collections;

public class GameInfo: MonoBehaviour {

	float score;
	bool needInit=true;
	public int nrPatos = 0;
	public int maxPatos = 6;
	public float velocidadeX;
	public float velocidadeY;
	public bool miss = false;

	float startTime;
	int restSeconds;
	int countDownSeconds;

	public float missX=0;
	public float missY=0;

	public Font fonte;

	void Start (){
		DontDestroyOnLoad (this);
		startTime = (float) Time.time;
		countDownSeconds = 30;
	}

	public void aumentaScore(){
		score = score + 10;
	}

	public void diminuiScore(){
		score = score - 10;
	}

	GUIStyle myStyle = new GUIStyle();

	void init(){
		velocidadeX = 2;
		velocidadeY = 2;
		score = 0;
		myStyle.normal.textColor = Color.black;
		myStyle.font = fonte;
	}

	bool fimJogo = false;

	void OnGUI(){
		if (!fimJogo){
			if (needInit == true) {
				init();
				needInit = false;
			}
			GUI.Label(new Rect(700,5,100,20), "Score: " + score, myStyle);

			//Tempo

			float actualTime = (float) (Time.time) - startTime;
			restSeconds = countDownSeconds - (int) actualTime;
			
			if (restSeconds == 0) {
				Application.LoadLevel(2);
			}
			GUI.Label(new Rect(10,5,100,20), "Tempo restante: " + restSeconds, myStyle);
		}
		else GUI.Label(new Rect(700,5,100,20), "Score: " + score, myStyle);
	}

}
