using UnityEngine;

public class FlashlightController : MonoBehaviour {

	Vector3 mousePos;
	int screenMidWidth;
	int screenMidHeight;

	int offsetX;
	int offsetY;

	void Awake ()
	{
		mousePos = new Vector3();
		screenMidWidth = Screen.width/2;
		screenMidHeight = Screen.height/2;
	}

	void Update () 
	{
		mousePos = Input.mousePosition;
		Debug.Log(mousePos);

		offsetX = (int)mousePos.x - screenMidWidth;
		offsetY = (int)mousePos.y - screenMidHeight;

		gameObject.transform.rotation = Quaternion.Euler(-offsetY, offsetX, 0.0f);
	}
}
