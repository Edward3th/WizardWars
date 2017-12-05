using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempSummonController : MonoBehaviour {
	private bool isInteracting;


	// E3: This script is temporary as it will have the behaviour of the summonings in general
	// the idea is for it to represent most card, but thereafter there will be one for each.
	void Update()
	{



	}

	void OnMouseDown()
	{
		if (Input.GetMouseButton (0)) {
			Debug.Log("Interacting with summon");
			isInteracting = true;
		}
	}

	void OnGUI()
	{
		if (isInteracting) {
			GUI.Box (new Rect (Event.current.mousePosition.x, Event.current.mousePosition.y - 200, 200, 200), "State menu");
		}
	}
}
