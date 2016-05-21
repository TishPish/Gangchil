using UnityEngine;
using System.Collections;

public class cameramove : MonoBehaviour {

	public int pos;
	public Vector2 velocity;
	public Rigidbody2D rigidbody2D;

	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Debug.Log(rigidbody.get
		rigidbody2D.velocity =velocity ;
		if (transform.position.x > 13) 
		{
			velocity = new Vector2 (pos*-1, 0);
		}
		if (transform.position.x < 1) 
		{
			velocity = new Vector2 (pos*1, 0);
		}
	}
}
