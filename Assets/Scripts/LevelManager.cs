using UnityEngine;

public class LevelManager : MonoBehaviour {

	public int level { get; set; }
	public int subLevel { get; set; }

	public bool completed { get; set; }

	MenuManager menu;

	void Start () 
	{
		level = 0;
		subLevel = 0;
		completed = true;
		menu = GetComponent<MenuManager>();
	}

	void Update () 
	{
		completed = FindObjectsOfType<Boogeyman>().Length == 0;

		if(Input.GetKeyUp(KeyCode.Escape))
			Application.Quit();

		if(subLevel > 3)
		{
			level++;
			subLevel = 1;
		}
	}

	public void loseGame ()
	{
		Debug.Assert(menu);
		Debug.Log("Moving menu.");
		level = 0;
		subLevel = 0;
		menu.setMenuInside(menu.gameOver);
	}

	public void startGame ()
	{
		Debug.Assert(menu);
		level = 1;
		subLevel = 1;
		menu.setMenuOutside(menu.mainMenu);
	}

	public void quitGame ()
	{
		Application.Quit();
	}
}
