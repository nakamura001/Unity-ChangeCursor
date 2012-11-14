using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
	public Texture2D cursorTexture;
	Vector2 hotSpot;
	
	void Awake ()
	{
		hotSpot = new  Vector2(12f, 8f);
	}
	
	void OnMouseEnter () 
	{
	    Cursor.SetCursor(cursorTexture, hotSpot, CursorMode.Auto);
	}
	
	void OnMouseExit ()
	{
		Cursor.SetCursor (null, Vector2.zero, CursorMode.Auto);
	}
}
