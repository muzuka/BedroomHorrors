﻿using UnityEngine;

public class BoogeymanManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _boogeyman;

    [SerializeField]
    private LevelManager _levelManager;

	Vector3 frontOrigin;
	Vector3 rightOrigin;
	Vector3 leftOrigin;
	Vector3 closetOrigin;

	void Start () 
	{
		frontOrigin = new Vector3(-2.5f, -0.3f, -2.15f);
		rightOrigin = new Vector3(-3.0f, -0.3f, -2.75f);
		leftOrigin = new Vector3(-3.0f, -0.3f, -1.75f);
		closetOrigin = new Vector3(1.0f, 0.25f, -2.0f);
	}

	void Update () 
	{
		if(_levelManager.completed)
		{
			_levelManager.completed = false;
			switch(_levelManager.level)
			{
			case 1:
				//Debug.Log("Level 1");
				levelOneActivate();
				_levelManager.subLevel++;
				break;
			case 2:
				//Debug.Log("Level 2");
				levelTwoActivate();
				_levelManager.subLevel++;
				break;
			case 3:
				//Debug.Log("Level 3");
				levelThreeActivate();
				_levelManager.subLevel++;
				break;
			case 4:
				//Debug.Log("Level 4");
				levelFourActivate(); 
				_levelManager.subLevel++;
				break;
			case 5:
				//Debug.Log("Level 5");
				levelFiveActivate();
				_levelManager.subLevel++;
				break;
			}
		}
	}

	void levelOneActivate ()
	{
		switch(_levelManager.subLevel)
		{
		case 1:
			spawnBoogeyman(frontOrigin);
			break;
		case 2:
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			break;
		case 3:
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			break;
		}
	}

	void levelTwoActivate ()
	{
		switch(_levelManager.subLevel)
		{
		case 1:
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			break;
		case 2:
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			break;
		case 3:
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			break;
		}
	}

	void levelThreeActivate ()
	{
		switch(_levelManager.subLevel)
		{
		case 1:
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			break;
		case 2:
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			break;
		case 3:
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			break;
		}
	}

	void levelFourActivate ()
	{
		switch(_levelManager.subLevel)
		{
		case 1:
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			break;
		case 2:
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			break;
		case 3:
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			break;
		}
	}

	void levelFiveActivate ()
	{
		switch(_levelManager.subLevel)
		{
		case 1:
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			break;
		case 2:
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			break;
		case 3:
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			spawnBoogeyman(frontOrigin);
			spawnBoogeyman(leftOrigin);
			spawnBoogeyman(rightOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			spawnBoogeyman(closetOrigin);
			break;
		}
	}

	void spawnBoogeyman (Vector3 origin)
	{
		Instantiate(_boogeyman, origin, _boogeyman.transform.rotation);
	}
}
