using UnityEngine;
using UnityEngine.Events;

public class MenuManager : MonoBehaviour {

	public GameObject mainMenu;
	public GameObject gameOver;

	const float outside = -180.0f;
	const float inside = -176.425f;

	void Start () 
	{
		setMenuOutside(gameOver);
	}

	public void setMenuInside (GameObject menu)
	{
		RectTransform menuTransform = menu.GetComponent<RectTransform>();
		menuTransform.anchoredPosition = new Vector3(menuTransform.anchoredPosition.x, inside);
		//menu.transform.Translate(new Vector3(0.0f, -10.0f));
	}

	public void setMenuOutside (GameObject menu)
	{
		Debug.Log(outside);
		RectTransform menuTransform = menu.GetComponent<RectTransform>();
		menuTransform.anchoredPosition = new Vector2(menuTransform.anchoredPosition.x, outside);
		//menu.transform.Translate(new Vector3(0.0f, 10.0f));
	}
}
