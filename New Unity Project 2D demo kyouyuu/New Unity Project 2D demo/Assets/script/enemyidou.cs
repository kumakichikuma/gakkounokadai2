using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyidou : MonoBehaviour
{

	float fallSpeed;
	float yokoidou;
	float seconds;
	public GameObject EnemyBullet;

	void Start()
	{
		this.fallSpeed = 0.02f;
		this.yokoidou = 0.02f;
		InvokeRepeating("GenRock", 1.5f, 0.5f);

	}


	void Update()
	{
		seconds += Time.deltaTime;
		if (seconds <= 3)
		{
			transform.Translate(0, -fallSpeed, 0, Space.World);
		}
		if (3 < seconds)
		{
			transform.Translate(yokoidou, 0, 0, Space.World);
		}
		if (4.4f < seconds)
		{
			transform.Translate(-yokoidou, fallSpeed ,0, Space.World);
		}
		if (7 < seconds)
		{
			transform.Translate(-yokoidou, -fallSpeed, 0, Space.World);
		}
		if (15 < seconds)
        {
			Destroy(gameObject);
		}
	}

	void GenRock()
	{
		Instantiate(EnemyBullet, transform.position, Quaternion.identity);
	}
}
