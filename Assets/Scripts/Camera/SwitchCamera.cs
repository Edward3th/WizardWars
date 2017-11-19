using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour {

	public Camera playerCam;
	public Camera mapCam;

	void Start () {
		playerCam.enabled = true;
		mapCam.enabled = false;
		
	}
	

	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) 
		{
			playerCam.enabled = !playerCam.enabled;
			mapCam.enabled = !mapCam.enabled;
		}
	}
}
