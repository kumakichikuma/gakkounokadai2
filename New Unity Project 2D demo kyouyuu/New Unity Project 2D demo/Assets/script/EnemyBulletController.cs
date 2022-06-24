using UnityEngine;
using System.Collections;

public class EnemyBulletController : MonoBehaviour
{

	public GameObject explosionPrefab;

	void Update()
	{
		transform.Translate(0, -0.2f, 0);

		if (transform.position.y < -11)
		{
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		// �Փ˂����Ƃ��ɃX�R�A���X�V����
		GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

		// �����G�t�F�N�g�𐶐�����	
		GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
		Destroy(effect, 1.0f);

		Destroy(coll.gameObject);
		Destroy(gameObject);
	}
}