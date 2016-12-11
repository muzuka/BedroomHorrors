using UnityEngine;
using System.Collections;

public class FlashlightController : MonoBehaviour {

	Vector3 mousePos;

	void Awake ()
	{
		mousePos = new Vector3();
	}

	void Update () 
	{
		mousePos = Input.mousePosition;
	}
}
