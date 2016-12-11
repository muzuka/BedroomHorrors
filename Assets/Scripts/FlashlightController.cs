using UnityEngine;

public class FlashlightController : MonoBehaviour {

	Vector3 mousePos;
	int screenMidWidth;
	int screenMidHeight;

	int offsetX;
	int offsetY;
	int clampX;
	int clampY;

	void Awake ()
	{
		mousePos = new Vector3();
		screenMidWidth = Screen.width/2;
		screenMidHeight = Screen.height/2;

		clampX = 50;
		clampY = 30;
	}

	void Update () 
	{
		mousePos = Input.mousePosition;
		Debug.Log(mousePos);

		offsetX = (int)mousePos.x - screenMidWidth;
		offsetY = (int)mousePos.y - screenMidHeight;

		if(offsetX > clampX)
		{
			offsetX = clampX;
		}
		else if(offsetX < -clampX)
		{
			offsetX = -clampX;
		}

		if(offsetY > clampY)
		{
			offsetY = clampY;
		}
		else if(offsetY < -clampY)
		{
			offsetY = -clampY;
		}

		gameObject.transform.rotation = Quaternion.Euler(-offsetY, 90+offsetX, 0.0f);
	}
}
