using UnityEngine;

public class MenuManager : MonoBehaviour {

	public GameObject mainMenu;
	public GameObject gameOver;
	public GameObject youWin;

	const float outside = -180.0f;
	const float inside = -176.425f;

	void Start () 
	{
		setGameOver(false);
		setYouWin(false);
	}

    public void setGameOver(bool value)
    {
        gameOver.SetActive(value);
    }

	public void setMainMenu(bool value)
	{
		mainMenu.SetActive(false);
	}

    public void setYouWin(bool value)
    {
        youWin.SetActive(value);
    }
}
