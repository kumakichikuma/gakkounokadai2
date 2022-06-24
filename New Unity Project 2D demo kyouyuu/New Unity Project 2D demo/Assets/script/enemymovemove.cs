using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovemove : MonoBehaviour
{

	float fallSpeed;
	float yokoidou;
	float seconds;

	void Start()
	{
		this.fallSpeed = 0.01f;
		this.yokoidou = 0.01f;

	}


	void Update()
	{
		seconds += Time.deltaTime;
		if (seconds <= 1)
		{
			transform.Translate(yokoidou,fallSpeed, 0, Space.World);
		}
		if (1<seconds)
		{
			transform.Translate(yokoidou, -fallSpeed,  0, Space.World);
		}
		if (2 < seconds )
		{
			transform.Translate(0, 2 *fallSpeed,  0, Space.World);
		}
		if(3< seconds )
        {
			transform.Translate(0, -2 * fallSpeed,  0, Space.World);
		}
		if (4 < seconds)
		{
			transform.Translate(0, 3 * fallSpeed, 0, Space.World);
		}
		if (15 < seconds)
		{
			Destroy(gameObject);
		}
	}
}
