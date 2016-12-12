using UnityEngine;

public static class Raycaster {

	public static Ray getRay () 
	{
		Vector3 mPos = Input.mousePosition;
		return Camera.main.ScreenPointToRay(mPos);
	}

	public static RaycastHit shootMouseRay ()
	{
		RaycastHit hit;
		Physics.Raycast(getRay(), out hit);
		return hit;
	}

}
