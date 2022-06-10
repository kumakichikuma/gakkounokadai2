using UnityEngine;
using System.Collections;

public class enemyhassei : MonoBehaviour
{

	public GameObject rockPrefab;

	void Start()
	{
		InvokeRepeating("GenRock",1 , 0.5f);
	}

	void GenRock()
	{
		Instantiate(rockPrefab, new Vector3(-5, 5, 0), Quaternion.identity);
	}
}