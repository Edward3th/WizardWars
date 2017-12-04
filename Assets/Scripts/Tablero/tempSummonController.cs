using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempSummonController : MonoBehaviour {
	private bool isInteracting;

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
			
		}
	}
}
