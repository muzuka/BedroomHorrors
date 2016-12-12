using UnityEngine;

public class FlashlightController : MonoBehaviour {

	Vector3 mousePos;
	int screenMidWidth;
	int screenMidHeight;

	int offsetX;
	int offsetY;
	const int clampX = 50;
	const int clampY = 30;
	const int clampYDown = -10;

	void Start ()
	{
		mousePos = new Vector3();
		screenMidWidth = Screen.width/2;
		screenMidHeight = Screen.height/2;
	}

	void Update () 
	{
		mousePos = Input.mousePosition;

		//shootRay();

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
		else if(offsetY < clampYDown)
		{
			offsetY = clampYDown;
		}

		gameObject.transform.rotation = Quaternion.Euler(-offsetY, 90+offsetX, 0.0f);
	}
}
