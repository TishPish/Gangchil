using UnityEngine;
using System.Collections;

public class weclick : MonoBehaviour {

	// Use this for initialization
	public void changeScene(string Scene)
	{
		Application.LoadLevel (Scene);
	}


}
