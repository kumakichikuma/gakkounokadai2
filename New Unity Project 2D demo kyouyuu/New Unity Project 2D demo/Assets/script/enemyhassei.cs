using UnityEngine;
using System.Collections;

public class enemyhassei : MonoBehaviour
{
	float seconds;
	public GameObject rockPrefab;

	void Start()
	{
		InvokeRepeating("GenRock",1 , 0.5f);
	}

	void Update()
    {
		seconds += Time.deltaTime;
		if(seconds > 5)
        {
			Destroy(gameObject);
        }
    }

	void GenRock()
	{
		Instantiate(rockPrefab, new Vector3(-5, 5, 0), Quaternion.identity);
	}
}