using UnityEngine;
using System.Collections;

public class birdmove : MonoBehaviour {

	public int speed;
	public int direction;
	public Vector2 velocity = new Vector2(-1, 0);
	public Rigidbody2D rigidbody2D;

	void Start () 
	{
		transform.position = new Vector3(transform.position.x, transform.position.y  * Random.value, transform.position.z);
	}

	// Update is called once per frame
	void Update () 
	{
		rigidbody2D.velocity =velocity ;
		velocity = new Vector2 (speed*direction, 0);

	}
}
