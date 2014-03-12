using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour 
{
	public Texture2D cursorImage;
	
	private int cursorWidth = 32;
	private int cursorHeight = 32;
	
	void Start(){
		Screen.showCursor = false;
	}
	
	
	void OnGUI(){
		GUI.DrawTexture(new Rect(Input.mousePosition.x-16, Screen.height - Input.mousePosition.y-16, cursorWidth, cursorHeight), cursorImage);
	}
}