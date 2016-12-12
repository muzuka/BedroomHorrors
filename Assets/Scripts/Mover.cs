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
		rotateStep = 0.05f;
		destination = Vector3.zero;
		velocity = Vector3.Normalize(velocity) * speed;
		directionToDestination = destination - gameObject.transform.position;
		rotationToDestination = Quaternion.FromToRotation(velocity, directionToDestination);
	}

	void Update () 
	{
		destination = GetComponent<Boogeyman>().destination;
		directionToDestination = destination - gameObject.transform.position;

		gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, rotationToDestination, rotateStep);

		moveBoogeyman();
	}

	void moveBoogeyman ()
	{
		velocity = Vector3.Normalize(velocity) * speed;
		step = speed * Time.deltaTime;
		gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, destination, step);
	}
}
