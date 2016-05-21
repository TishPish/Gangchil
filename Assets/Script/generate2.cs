using UnityEngine;
using System.Collections;

public class generate2 : MonoBehaviour {

	public GameObject rocks;
	public float time = 1f;
	public float speed = 1.5f;
	void Start()
	{
		InvokeRepeating("CreateObstacle", time, speed);
	}


	void CreateObstacle()
	{
		Instantiate(rocks);
	}
}
