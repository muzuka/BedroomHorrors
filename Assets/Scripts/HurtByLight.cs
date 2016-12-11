using UnityEngine;
using System.Collections;

public class HurtByLight : MonoBehaviour {

	int health;

	void Start () {
		health = 10;
	}

	void Update () {
		if(health <= 0)
			Destroy(gameObject);
	}
}
