using UnityEngine;

public class LevelManager : MonoBehaviour {

	public int level { get; set; }
	public int subLevel { get; set; }

	public bool completed { get; set; }

	public MenuManager menu;

	void Start () 
	{
		level = 0;
		subLevel = 0;
		completed = true;
		//Debug.Assert(menu);
	}

	void Update () 
	{
		completed = FindObjectsOfType<Boogeyman>().Length == 0;

		if(Input.GetKeyUp(KeyCode.Escape))
			Application.Quit();

		if(level == 6 && completed)
		{
			//Debug.Log("You won!");
			menu.setYouWin(true);
		}

		if(subLevel > 3)
		{
			//Debug.Log("Next Level!");
			level++;
			subLevel = 1;
		}
	}

	public void loseGame ()
	{
		//Debug.Assert(menu);
		//Debug.Log("Moving menu.");
		level = 0;
		subLevel = 0;
		menu.setGameOver(true);
	}

	public void startGame ()
	{
		//Debug.Assert(menu);
		level = 1;
		subLevel = 1;
		menu.setMainMenu(false);
		menu.setYouWin(false);
		menu.setGameOver(false);
	}

	public void quitGame ()
	{
		Application.Quit();
	}
}
