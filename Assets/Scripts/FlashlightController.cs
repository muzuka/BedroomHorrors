using UnityEngine;
using UnityEngine.Events;

public class FlashlightController : MonoBehaviour {

	public UnityEvent deathEvent; 

	Vector3 mousePos;
	int screenMidWidth;
	int screenMidHeight;

	const float timeToKill = 0.1f;
	float timeConsumed;

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
		timeConsumed = 0.0f;
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

	void shootRay ()
	{
		if(Raycaster.shootMouseRay().transform != null)
		{
			Debug.Log("Hit boogeyman.");
			timeConsumed += Time.deltaTime;
			if(timeConsumed >= timeToKill)
			{
				deathEvent.Invoke();
			}
		}
		else
		{
			timeConsumed = 0.0f;
		}
	}
}
