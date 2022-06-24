using UnityEngine;
using System.Collections;

public class player : MonoBehaviour
{

	public GameObject PlayerBullet;

	void Update()
	{
		if (Input.GetKey(KeyCode.LeftArrow)&& transform.position.x > -5.5)
		{
			transform.Translate(-0.1f, 0, 0);
		}
		if (Input.GetKey(KeyCode.RightArrow)&& transform.position.x < 5.5)
		{
			transform.Translate(0.1f, 0, 0);
		}
		if (Input.GetKey(KeyCode.UpArrow)&& transform.position.y < 9.5)
        {
			transform.Translate(0, 0.1f, 0);
		}
		if (Input.GetKey(KeyCode.DownArrow)&& transform.position.y > -9.5)
		{
			transform.Translate(0, -0.1f, 0);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(PlayerBullet, transform.position, Quaternion.identity);
		}
	}
}