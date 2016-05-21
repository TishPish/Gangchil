using UnityEngine;
using System.Collections;

public class touch : MonoBehaviour 
{

	public float minSwipeDistY=50;
	public string next;
	public string previous;
	public float minSwipeDistX=50;

	private Vector2 startPos;

	void Update()
	{
		if (Input.touchCount > 0) 

		{

			Touch touch = Input.touches[0];

			switch (touch.phase) 

			{

				case TouchPhase.Began:

				startPos = touch.position;

				break;



			case TouchPhase.Ended:

				float swipeDistVertical = (new Vector3 (0, touch.position.y, 0) - new Vector3 (0, startPos.y, 0)).magnitude;

				if (swipeDistVertical > minSwipeDistY) {

					float swipeValue = Mathf.Sign (touch.position.y - startPos.y);

					if (swipeValue > 0) {//up swipe
						//Jump ();
					} else if (swipeValue < 0) {//down swipe
						//Shrink ();

					}

					float swipeDistHorizontal = (new Vector3 (touch.position.x, 0, 0) - new Vector3 (startPos.x, 0, 0)).magnitude;

					if (swipeDistHorizontal > minSwipeDistX) {

						float swipeVale = Mathf.Sign (touch.position.x - startPos.x);

						if (swipeVale > 0) 
						{//right swipe
							Application.LoadLevel(previous);
						} 
						else if (swipeVale < 0) {//left swipe
							Application.LoadLevel(next);

						}
						break;
					}
				}
				break;
	}
}
	}
}