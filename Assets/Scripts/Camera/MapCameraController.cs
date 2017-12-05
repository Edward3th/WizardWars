using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCameraController : MonoBehaviour {

	public Transform camController;

	private Vector3 initialPos;
	private Quaternion initialRot;
	float rotationSpeed = 5.0f;
	float moveSpeed = 20.0f;

	void Start () {
		initialPos = camController.position;
		initialRot = camController.rotation;
	}
	

	void Update () {

	
		transform.position = new Vector3(
			Mathf.Clamp(transform.position.x,-42.0f,42.0f),
			transform.position.y,
			Mathf.Clamp(transform.position.z,-42.0f,42.0f));

		float translation = Time.deltaTime * moveSpeed;
		if (Input.GetKey("a")){
			transform.Translate (translation, 0, 0);
		}
		if (Input.GetKey("s")){
			transform.Translate (0, 0,translation);
		}
		if (Input.GetKey("d")){
			transform.Translate (-translation, 0, 0);
		}
		if (Input.GetKey("w")){
			transform.Translate (0, 0, -translation);
		}

		if (Input.GetMouseButton(1)){
			float h = rotationSpeed * Input.GetAxis ("Mouse X");
			float v = rotationSpeed * Input.GetAxis ("Mouse Y");
			transform.Rotate (0, h, 0);
		}

		if (Input.GetButtonDown("reset"))
		{
			camController.SetPositionAndRotation(initialPos,initialRot);
		}
	}
}
