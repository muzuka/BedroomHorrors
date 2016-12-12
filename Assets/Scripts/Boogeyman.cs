using UnityEngine;

public class Boogeyman : MonoBehaviour {

	const float minX = -2.0f;
	const float maxX = 0.8f;
	const float minZ = -3.0f;
	const float maxZ = 0.0f;
	const float minY = 0.0f;
	const float maxY = 1.0f;

	bool flying;
	bool attack;

	float timeConsumed;
	float timeToAttack;

	public Vector3 destination { get; set; }

	void Start () 
	{
		flying = true;
		attack = false;

		timeToAttack = 5.0f;
		timeConsumed = 0.0f;

		destination = Vector3.zero;
	}

	void Update () 
	{
		if(attack)
		{
			destination = FindObjectOfType<Camera>().transform.position;
			GetComponent<Mover>().speed = 10;
			// TODO
			// check distance
			// if in killzone player loses
			if(Vector3.Distance(gameObject.transform.position, destination) <= 1.0f)
				Destroy(gameObject);
		}

		if(flying)
		{
			// TODO
			// start timer
			timeConsumed += Time.deltaTime;
			if(timeConsumed >= timeToAttack)
			{
				flying = false;
				attack = true;
				return;
			}
			// get random position as destination
			if(destination.Equals(Vector3.zero))
				destination = getRandomDestination();
			// Once reached choose another
			if(Vector3.Distance(gameObject.transform.position, destination) <= 1.0f)
				destination = getRandomDestination();
			// When timer runs out switch to attack mode
		}
	}

	Vector3 getRandomDestination () 
	{
		float randX = Random.Range(minX, maxX);
		float randY = Random.Range(minY, maxY);
		float randZ = Random.Range(minZ, maxZ);

		return new Vector3(randX, randY, randZ);
	}
}
