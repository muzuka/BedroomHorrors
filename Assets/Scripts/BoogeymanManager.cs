using UnityEngine;

public class BoogeymanManager : MonoBehaviour {

	Vector3 frontOrigin;
	Vector3 rightOrigin;
	Vector3 leftOrigin;
	Vector3 closetOrigin;

	void Start () {
		frontOrigin = new Vector3(-2.5f, -0.3f, -2.15f);
		rightOrigin = new Vector3(-3.0f, -0.3f, -2.75f);
		leftOrigin = new Vector3(-3.0f, -0.3f, -1.75f);
		closetOrigin = new Vector3(1.0f, 0.25f, -2.0f);
	}

	void Update () {

		if(GetComponent<LevelManager>().completed)
		{
			GetComponent<LevelManager>().completed = false;
			switch(GetComponent<LevelManager>().level)
			{
			case 1:
				levelOneActivate();
				GetComponent<LevelManager>().subLevel++;
				break;
			case 2:
				levelTwoActivate();
				GetComponent<LevelManager>().subLevel++;
				break;
			case 3:
				levelThreeActivate();
				GetComponent<LevelManager>().subLevel++;
				break;
			}
		}
	}

	void levelOneActivate()
	{
		switch(GetComponent<LevelManager>().subLevel)
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

	void levelTwoActivate()
	{
		switch(GetComponent<LevelManager>().subLevel)
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

	void levelThreeActivate()
	{
		switch(GetComponent<LevelManager>().subLevel)
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

	void spawnBoogeyman(Vector3 origin)
	{
		Instantiate(Resources.Load("Prefabs/Boogeyman_Weak"), origin, Quaternion.identity);
	}
}
