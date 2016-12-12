using UnityEngine;

public class Mover : MonoBehaviour {

	public Vector3 velocity;
	public float speed;

	float step;
	const float rotateStep = 0.5f;

	Vector3 directionToDestination;
	Vector3 destination;
	Quaternion rotationToDestination;

	void Start () 
	{
		destination = Vector3.zero;
		velocity = Vector3.Normalize(velocity) * speed;
		directionToDestination = destination - transform.position;
		rotationToDestination = Quaternion.FromToRotation(velocity, directionToDestination);
	}

	void Update () 
	{
		destination = GetComponent<Boogeyman>().destination;
		directionToDestination = destination - transform.position;
		rotationToDestination = Quaternion.FromToRotation(velocity, directionToDestination);

		transform.rotation = Quaternion.Lerp(transform.rotation, rotationToDestination, rotateStep);
		moveBoogeyman();
	}

	void moveBoogeyman ()
	{
		velocity = Vector3.Normalize(velocity) * speed;
		step = speed * Time.deltaTime;
		transform.position = Vector3.Lerp(transform.position, destination, step);
	}
}
