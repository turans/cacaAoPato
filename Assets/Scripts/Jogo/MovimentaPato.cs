using UnityEngine;
using System.Collections;

public class MovimentaPato : MonoBehaviour {

	public GameInfo instanceGI;
	bool movP = true;
	float movX=0,movY=0;
	// Use this for initialization
	void Start () {
		instanceGI = (GameInfo)FindObjectOfType (typeof(GameInfo));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			RaycastHit hit = new RaycastHit();
			//Verifica se o clique do mouse foi no pato
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit) && hit.transform.tag == "Pato"){
				StartCoroutine(killDuck(hit));
			}
			else {
				instanceGI.missX = Input.mousePosition.x;
				instanceGI.missY = Input.mousePosition.y;
				instanceGI.miss = true;
			}
		}
		if (movP){
			StartCoroutine(movPato());
			movP = false;
		}
		Vector3 posicao = transform.position + new Vector3(movX,movY,0) * Time.deltaTime;
		if (posicao.x > 6)	posicao.x = 6;
		else if (posicao.x < -6) posicao.x = -6;

		if (posicao.y > 4)	posicao.y = 4;
		else if (posicao.y < -3) posicao.y = -3;

		transform.position = posicao;
	}

	IEnumerator movPato(){
		while (true){
			yield return new WaitForSeconds (0.33f);
			int positiveX,positiveY;
			positiveX = (int) (Random.value * 100); 
			positiveY = (int) (Random.value * 100); 
			
			if (positiveX > 50) positiveX = 1;
			else positiveX = -1;
			
			if (positiveY > 50) positiveY = 1;
			else positiveY = -1;
			
			movX = positiveX * (Random.value * instanceGI.velocidadeX);
			movY = positiveY * (Random.value * instanceGI.velocidadeY);
		}
	}

	IEnumerator killDuck(RaycastHit hit){
		yield return new WaitForSeconds (0.33f);
		if (hit.collider.gameObject){
			Destroy (hit.collider.gameObject);
		}
		int patos = GameObject.FindGameObjectsWithTag ("Pato").Length;
		instanceGI.nrPatos = patos - 1;
	}
}
