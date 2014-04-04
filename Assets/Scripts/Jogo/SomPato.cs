using UnityEngine;
using System.Collections;

public class SomPato : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit = new RaycastHit();
			//Verifica se o clique do mouse foi no pato
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit) && hit.transform.tag == "Pato"){
				//Executa o som do pato levando um tiro
				GetComponent<AudioSource>().Play();
			}
		}
	}
}
