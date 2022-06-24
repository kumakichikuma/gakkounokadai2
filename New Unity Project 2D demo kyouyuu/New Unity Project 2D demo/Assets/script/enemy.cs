using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour
{

	float fallSpeed;
	float rotSpeed;

	void Start()
	{
		this.fallSpeed = 0.01f;
		this.rotSpeed = 1f;
	}

	void Update()
	{
		transform.Translate(0, -fallSpeed, 0, Space.World);
		transform.Rotate(0, 0, rotSpeed);

		if (transform.position.y < -10f)
		{
			Destroy(gameObject);
		}
	}
}