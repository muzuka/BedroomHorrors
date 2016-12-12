using UnityEngine;

public class HurtByLight : MonoBehaviour {

	int maxHealth;
	int health;

	void Start () 
	{
		maxHealth = 10;
		health = maxHealth;
	}

	void Update () 
	{
		if(health <= 0)
			Destroy(gameObject);
	}

	void OnTriggerStay ()
	{
		Debug.Log("Light is on boogeyman.");
		health--;
	}

	void OnTriggerExit ()
	{
		Debug.Log("Light has left the boogeyman.");
		health = maxHealth;
	}
}
