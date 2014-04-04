using UnityEngine;
using System.Collections;

public class CriaPato : MonoBehaviour {

	int maxPatos = 0;
	public GameObject pato;
	public GameInfo instanceGI;

	// Use this for initialization
	void Start () {
		instanceGI = (GameInfo)FindObjectOfType (typeof(GameInfo));
		maxPatos = instanceGI.maxPatos;
	}
	
	// Update is called once per frame
	void Update () {
		if (instanceGI.nrPatos < maxPatos) StartCoroutine (proxPato ());
	}

	void adicionaPato(){

		int positiveX = (int) (Random.value * 100); 
		int positiveY = (int) (Random.value * 100); 
		
		if (positiveX > 50) positiveX = 1;
		else positiveX = -1;
		
		if (positiveY > 50) positiveY = 1;
		else positiveY = -1;
		
		float posX = positiveX * (Random.value * 6);
		float posY = positiveY * (Random.value * 3);
		Instantiate (pato,new Vector3(posX,posY,0), Quaternion.Euler(0,180,0));
		instanceGI.nrPatos ++;
	}

	IEnumerator proxPato(){
		yield return new WaitForSeconds(1);
		if (instanceGI.nrPatos < maxPatos) adicionaPato ();
	}
}
