using UnityEngine;
using System.Collections;

public class enemyhassei2 : MonoBehaviour
{

	public GameObject rockPrefab;
	float seconds;

	void Start()
	{
		InvokeRepeating("GenRock", 1.5f, 0.5f);
	}

	void Update()
	{
		seconds += Time.deltaTime;
		if (seconds > 15)
		{
			Destroy(gameObject);
		}
	}

	void GenRock()
	{
		Instantiate(rockPrefab, new Vector3(-5, 9, 0), Quaternion.identity);
	}
}