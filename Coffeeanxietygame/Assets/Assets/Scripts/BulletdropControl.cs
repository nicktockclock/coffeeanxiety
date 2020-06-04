using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletdropControl : MonoBehaviour
{
	public float speed;

	void Update()
	{
		transform.position = transform.position + Vector3.down * speed * Time.deltaTime;
	}
}