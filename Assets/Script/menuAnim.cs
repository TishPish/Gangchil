using UnityEngine;
using System.Collections;

public class menuAnim : MonoBehaviour {

	public int speed;
	public int limit;
	public int direction;
	public Vector2 velocity = new Vector2(-1, 0);
	public Rigidbody2D rigidbody2D;

	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		Debug.Log ("in vaue" + rigidbody2D.transform.position.x);
		if (rigidbody2D.transform.position.x < limit) {
			velocity = new Vector2 (speed * direction, 0);
			rigidbody2D.velocity = velocity;
		} else {
			velocity = new Vector2 (0, 0);
			rigidbody2D.velocity = velocity;
		}
	}
}
