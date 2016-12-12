using UnityEngine;
using System.Collections;

public class LampController : MonoBehaviour {

	Light lampLight;

	void Start ()
	{
		lampLight = GetComponent<Light>();
	}

	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.Space))
		{
			if(lampLight.intensity >= 1.0f)
				lampLight.intensity = 0.0f;
			else
				lampLight.intensity = 1.1f;
		}
	}
}
