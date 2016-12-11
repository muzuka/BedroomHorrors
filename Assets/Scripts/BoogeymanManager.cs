using UnityEngine;

public class BoogeymanManager : MonoBehaviour {

	int level;

	Vector3 frontOrigin;
	Vector3 rightOrigin;
	Vector3 leftOrigin;

	void Start () {
		level = 1;
		frontOrigin = new Vector3(-2.5f, -0.3f, -2.15);
		rightOrigin = new Vector3(-3.0f, -0.3f, -2.75f);
		leftOrigin = new Vector3(-3.0f, -0.3f, -1.75f);
	}

	void Update () {
		
	}
}
