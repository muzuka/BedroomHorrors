﻿using UnityEngine;

public class LevelManager : MonoBehaviour {

	public int level { get; set; }
	public int subLevel { get; set; }

	public bool completed { get; set; }

	void Start () {
		level = 1;
		subLevel = 1;
		completed = true;
	}

	void Update () {
	
		if(FindObjectsOfType<Boogeyman>().Length == 0)
			completed = true;

		if(subLevel > 3)
		{
			level++;
			subLevel = 1;
		}
	}
}