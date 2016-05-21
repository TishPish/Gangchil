using UnityEngine;
using System.Collections;

public class loop2 : MonoBehaviour {

	public float speed=5f;
	public int initpos=0;
	public int direction=1;
	public Vector2 velocity = new Vector2(-1, 0);
	public Rigidbody2D rigidbody2D;
	public int limit = 15;

	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		rigidbody2D.velocity =velocity ;
		velocity = new Vector2 (speed*direction, 0);
		if (rigidbody2D.transform.position.x > limit)
		{
			Vector2 pos = this.transform.position;
			pos.x = initpos;
			this.transform.position = pos;
		}
	}
}
