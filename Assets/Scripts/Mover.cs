using UnityEngine;

public class Mover : MonoBehaviour {

	public Vector3 velocity;
	public float speed;

	float step;
	float rotateStep;

	Vector3 directionToDestination;
	Vector3 destination;
	Quaternion rotationToDestination;

	void Start () 
	{
		rotateStep = 0.5f;
		destination = Vector3.zero;
		velocity = Vector3.Normalize(velocity) * speed;
		directionToDestination = destination - transform.position;
		rotationToDestination = Quaternion.FromToRotation(velocity, directionToDestination);
	}

	void Update () 
	{
		destination = GetComponent<Boogeyman>().destination;
		directionToDestination = destination - transform.position;

		transform.rotation = Quaternion.Lerp(transform.rotation, rotationToDestination, rotateStep);
		velocity = transform.rotation.eulerAngles;
		moveBoogeyman();
	}

	void moveBoogeyman ()
	{
		velocity = Vector3.Normalize(velocity) * speed;
		step = speed * Time.deltaTime;
		transform.position = Vector3.Lerp(transform.position, destination, step);
	}
}
