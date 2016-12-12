using UnityEngine;
using UnityEditor;

public class LevelManager : MonoBehaviour {

	public int level { get; set; }
	public int subLevel { get; set; }

	public bool completed { get; set; }

	void Start () 
	{
		level = 0;
		subLevel = 0;
		completed = true;
	}

	void Update () 
	{
	
		if(FindObjectsOfType<Boogeyman>().Length == 0)
			completed = true;

		if(subLevel > 3)
		{
			level++;
			subLevel = 1;
		}
	}

	public void loseGame ()
	{
		level = 0;
		subLevel = 0;
		GetComponent<MenuManager>().gameOver.SetActive(true);
	}

	public void startGame ()
	{
		level = 1;
		subLevel = 1;
		GetComponent<MenuManager>().mainMenu.SetActive(false);
	}

	public void quitGame ()
	{
		Application.Quit();
		EditorApplication.isPlaying = false;
	}
}
