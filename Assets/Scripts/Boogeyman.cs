using UnityEngine;
using UnityEngine.Events;

public class Boogeyman : MonoBehaviour {

	public UnityEvent loseEvent;

	public AudioClip screamClip;
	const float volume = 0.5f;

	const float minX = -3.0f;
	const float maxX = 0.8f;
	const float minZ = -3.5f;
	const float maxZ = 0.0f;
	const float minY = 0.0f;
	const float maxY = 1.5f;

	bool flying;
	bool attack;

	float timeConsumed;
	const float timeToAttack = 5.0f;

	public Vector3 destination { get; set; }

	void Start () 
	{
		flying = true;
		attack = false;

		timeConsumed = 0.0f;

		destination = Vector3.zero;
	}

	void Update () 
	{
		if(attack)
		{
			destination = FindObjectOfType<Camera>().transform.position;
			GetComponent<Mover>().speed = 10;

			if(Vector3.Distance(gameObject.transform.position, destination) <= 0.5f)
			{
				Debug.Log("You Lost!");
				loseEvent.Invoke();
				AudioSource.PlayClipAtPoint(screamClip, transform.position, volume);
				Destroy(gameObject);
			}
				
		}

		if(flying)
		{
			timeConsumed += Time.deltaTime;
			if(timeConsumed >= timeToAttack)
			{
				flying = false;
				attack = true;
				return;
			}

			if(destination.Equals(Vector3.zero))
				destination = getRandomDestination();
			
			if(Vector3.Distance(gameObject.transform.position, destination) <= 1.0f)
				destination = getRandomDestination();
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
