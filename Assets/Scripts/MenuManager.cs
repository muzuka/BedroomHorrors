using UnityEngine;

public class MenuManager : MonoBehaviour {

	public GameObject mainMenu;
	public GameObject gameOver;
	public GameObject youWin;

	const float outside = -180.0f;
	const float inside = -176.425f;

	void Start () 
	{
		setGameOverOutside();
		setYouWinOutside();
	}

	public void setGameOverInside ()
	{
		gameOver.SetActive(true);
	}

	public void setGameOverOutside ()
	{
		gameOver.SetActive(false);
	}

	public void setMainMenuOutside ()
	{
		mainMenu.SetActive(false);
	}

	public void setYouWinInside ()
	{
		youWin.SetActive(true);
	}

	public void setYouWinOutside ()
	{
		youWin.SetActive(false);
	}
}
