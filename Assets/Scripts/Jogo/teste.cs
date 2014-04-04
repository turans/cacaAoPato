using UnityEngine;
using System.Collections;

public class teste : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private GUIStyle currentStyle = null;	
	void OnGUI(){   
		InitStyles();		
		GUI.Box( new Rect( 0, 0, 100, 100 ), "Hello", currentStyle );		
	}

	
	private void InitStyles(){
		if( currentStyle == null ){
			currentStyle = new GUIStyle( GUI.skin.box );
			currentStyle.normal.background = MakeTex( 2, 2, Color.red );
		}
	}
	
	private Texture2D MakeTex( int width, int height, Color col ){
		Color[] pix = new Color[width * height];
		for( int i = 0; i < pix.Length; ++i ){
			pix[ i ] = col;
		}
		Texture2D result = new Texture2D( width, height );
		result.SetPixels( pix );
		result.Apply();
		return result;
	}
}
