using UnityEngine;
using UnityEngine.UI;
public class Generate : MonoBehaviour
{
	public GameObject rocks;

	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}


	void CreateObstacle()
	{
		Instantiate(rocks);
	}
}