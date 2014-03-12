using UnityEngine;
using System.Collections;

public class GameLoop : MonoBehaviour {

	public int score;
	double tempo;
	public int isAnimation;
	public float OLDx,OLDy;
	public int miss;
	float x,y;

	// Use this for initialization
	void Start () {
		score = 0;
		miss = 0;
		isAnimation = 0;
		x = Random.value * 15;
		y = Random.value * (float) 8.3;

		OLDx = x;
		OLDy = y;
		
		transform.position = Vector2.right * x + Vector2.up * y;
	}
	
	// Update is called once per frame
	void Update () {

		tempo ++;
		if (tempo >= 20.0) {
			tempo = 0;
			isAnimation = 0;
			miss = 0;
		}


		if (Input.GetMouseButtonDown(0)){

			RaycastHit hitInfo = new RaycastHit();
			//Verifica se o clique do mouse foi no pato
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo) && hitInfo.transform.tag == "Pato"){
				//Aumenta a pontuaçao
				score += 10;

				//Executa o som do pato levando um tiro
				GetComponent<AudioSource>().Play();

				//Cria animaçao do pato levando o tiro
				isAnimation = 1;

				OLDx = x;
				OLDy = y;

				//Max. X = 15; Min. X = 0;
				//Max. Y = 8.3; Min. Y = 0;

				x = Random.value * 15;
				y = Random.value * (float) 8.3;

				//Procura nova posiçao para o pato
				transform.position = Vector2.right * x + Vector2.up * y;

			}
			else {
				miss = 1; 
			}
		}
	}

	void OnGUI(){	

		GUI.Label(new Rect(880,5,100,20), "Score: " + score);
		
	}
}
