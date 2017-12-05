using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour {


	private float w = Screen.width;
	private float h = Screen.height;

	public bool DrawPhase = false;
	public bool MainPhase = false;
	public bool BattlePhase = false; 
	public bool EndPhase = false;


	void Update()
	{
	}


	void OnGUI()
	{

		GUI.Box (new Rect (w * 0.8f, h * 0.01f, w * 0.1f, h * 0.06f) , "Time");
		GUI.Box (new Rect (w * 0.325f, h * 0.01f, w * 0.1f, h * 0.06f), " Summoning \n Phase");
		GUI.Box (new Rect (w*0.11f + w * 0.325f, h * 0.01f, w * 0.1f, h * 0.06f), " Battle \n Phase");
		GUI.Box (new Rect (w*0.22f + w * 0.325f, h * 0.01f, w * 0.1f, h * 0.06f), " Nexus \n Phase");
	}
}


