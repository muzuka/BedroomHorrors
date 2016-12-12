using UnityEngine;

public class HurtByLight : MonoBehaviour {

	const int maxHealth = 25;
	int health;

	void Start () 
	{
		health = maxHealth;
	}

	void Update () 
	{
		if(health <= 0)
		{
			AudioSource.PlayClipAtPoint(GetComponent<Boogeyman>().screamClip, transform.position, 2.0f);
			Destroy(gameObject);
		}
	}

	void OnTriggerStay ()
	{
		GetComponent<ParticleSystem>().Play();
		health--;
	}

	void OnTriggerExit ()
	{
		Debug.Log("Light has left the boogeyman.");
		Debug.Log("Reached " + health + " health.");
		health = maxHealth;
	}
}
