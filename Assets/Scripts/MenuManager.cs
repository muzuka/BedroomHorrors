using UnityEngine;
using UnityEngine.Events;

public class MenuManager : MonoBehaviour {

	public GameObject mainMenu;
	public GameObject gameOver;

	void Start () 
	{
		mainMenu.SetActive(true);
		gameOver.SetActive(false);
	}

	public void loseGame ()
	{
		gameOver.SetActive(true);
	}
}
