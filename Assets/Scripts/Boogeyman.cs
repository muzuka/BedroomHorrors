using UnityEngine;

public class Boogeyman : MonoBehaviour {

	bool flying;
	bool attack;

	Vector3 destination;

	void Start () {
		flying = true;
		attack = false;
	}

	void Update () {
		if(attack)
		{
			destination = FindObjectOfType<Camera>().transform.position;
			// TODO
			// check distance
			// if in killzone player loses
		}

		if(flying)
		{
			// TODO
			// start timer
			// get random position as destination
			// Once reached choose another
			// When timer runs out switch to attack mode
		}
	}
}
