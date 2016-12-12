using UnityEngine;
using UnityEngine.Events;

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
		Debug.Log("Game over has been placed inside.");
		RectTransform menuTransform = gameOver.GetComponent<RectTransform>();
		menuTransform.anchoredPosition = new Vector2(menuTransform.anchoredPosition.x, inside);
		Debug.Log("Game Over is at " + menuTransform.anchoredPosition);
	}

	public void setGameOverOutside ()
	{
		Debug.Log("Game over has been placed outside.");
		RectTransform menuTransform = gameOver.GetComponent<RectTransform>();
		menuTransform.anchoredPosition = new Vector2(menuTransform.anchoredPosition.x, outside);
	}

	public void setMainMenuOutside ()
	{
		Debug.Log("Main menu has been placed outside.");
		RectTransform menuTransform = mainMenu.GetComponent<RectTransform>();
		menuTransform.anchoredPosition = new Vector2(menuTransform.anchoredPosition.x, outside);
	}

	public void setYouWinInside ()
	{
		Debug.Log("Game over has been placed inside.");
		RectTransform menuTransform = youWin.GetComponent<RectTransform>();
		menuTransform.anchoredPosition = new Vector2(menuTransform.anchoredPosition.x, inside);
		Debug.Log("Game Over is at " + menuTransform.anchoredPosition);
	}

	public void setYouWinOutside ()
	{
		Debug.Log("Game over has been placed outside.");
		RectTransform menuTransform = youWin.GetComponent<RectTransform>();
		menuTransform.anchoredPosition = new Vector2(menuTransform.anchoredPosition.x, outside);
	}
}
