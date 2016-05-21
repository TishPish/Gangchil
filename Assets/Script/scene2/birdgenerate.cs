using UnityEngine;
using System.Collections;

public class birdgenerate : MonoBehaviour {

	public GameObject rocks;

	void Start()
	{
		InvokeRepeating("CreateObstacle", 0.01f, 0.3f);
	}


	void CreateObstacle()
	{
		Instantiate(rocks);
	}
}
